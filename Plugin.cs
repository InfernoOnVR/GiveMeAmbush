using BepInEx;
using Utilla;

namespace GiveMeBrawl
{
    [ModdedGamemode("AMBUSH","AMBUSH", Utilla.Models.BaseGamemode.Ambush)]
    [BepInDependency("org.legoandmars.gorillatag.utilla")]
    [BepInPlugin("GiveMeAmbush", "Give Me Ambush", "1.0.0")]
    public class Plugin : BaseUnityPlugin{}
}
