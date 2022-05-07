/*
 ########### README ####################################################
                                                                             
  !!! DON'T EDIT THIS FILE !!!
                                                                     
 ########### CHANGES ###################################################

 1.0.0
    - Plugin release

 #######################################################################
*/

namespace Oxide.Plugins
{
    [Info("Remove Safe Zone", "Paulsimik", "1.0.0")]
    [Description("Removing all safe zones on map")]
    class RemoveSafeZone : RustPlugin
    {
        private void OnServerInitialized()
        {
            var obj = UnityEngine.Object.FindObjectsOfType<TriggerSafeZone>();
            if (obj != null)
            {
                foreach (var objects in obj)
                {
                    if (objects != null)
                        UnityEngine.Object.Destroy(objects);
                }
            }
        }
    }
}