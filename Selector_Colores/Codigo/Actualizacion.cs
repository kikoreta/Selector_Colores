using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace Selector_Colores.Codigo {

    internal static class Actualizacion {

        public static void ActualizarSincronizarInfo() {

            if (!ApplicationDeployment.IsNetworkDeployed) return;

            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

            UpdateCheckInfo info;

            try { info = ad.CheckForDetailedUpdate(); }
            catch (DeploymentDownloadException dde) {
                MessageBox.Show($@"No se puede descargar la versión nueva de la aplicación en este momento, Por favor checa tu conexion de red, o intenta después. Error: {dde.Message}");

                return;
            }
            catch (InvalidDeploymentException ide) {
                MessageBox.Show($@"No se puede checar si hay actualizaciónes de la applicación, La Publicación esta corrupta. Error: {ide.Message}");

                return;
            }
            catch (InvalidOperationException ioe) {
                MessageBox.Show($@"No se puede actualizar esta aplicación, La Publicación esta corrupta. Error: {ioe.Message}");

                return;
            }

            if (!info.UpdateAvailable) return;

            {
                var doUpdate = true;

                if (!info.IsUpdateRequired) {
                    DialogResult dr = MessageBox.Show(@"Hay una Actualización disponible, Quieres aplicarla ahora?.", @"Actualización Disponible", MessageBoxButtons.OKCancel);

                    if (DialogResult.OK != dr) doUpdate = false;
                }
                else {
                    MessageBox.Show($@"Esta aplicación necesita actualizarse a la versión {info.MinimumRequiredVersion} la acutalización procedera a instalarse y se reiniciará la aplicación."
                                  , @"Actualización Disponible"
                                  , MessageBoxButtons.OK
                                  , MessageBoxIcon.Information);
                }

                if (!doUpdate) return;

                try {
                    ad.Update();
                    MessageBox.Show(@"La aplicación se actualizó y ocupa reiniciarse.");
                    Application.Restart();
                }
                catch (DeploymentDownloadException dde) {
                    MessageBox.Show($@"No se pudo instalar la última versión 

                                                Checa tu conexión a internet e intenta nuevamente. Error: {dde}");
                }
            }
        }

    }

}