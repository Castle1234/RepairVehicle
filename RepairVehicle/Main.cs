using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;


namespace RepairVehicle
{
    public class Main : BaseScript
    {
        [Command("repairvehicle")]
        private void RepairVehicle()
        {
            
            var localPlayer = Game.PlayerPed;
            var localVehicle = localPlayer.CurrentVehicle;
            

            if (localVehicle != null)
            {
                API.SetVehicleFixed(localVehicle.Handle);
                Screen.ShowNotification("Vehicle repaired.");
            }
            else
            {
                Screen.ShowNotification("You are not in a vehicle.");
            }
        }
    }
}
