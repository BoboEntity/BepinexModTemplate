using BepInEx;
using Utilla;

namespace ModTemplate
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.11")]
    [BepInPlugin("com.Author.ModName", "ModName", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // code
        }

        private void Start()
        {
            Events.GameInitialized += OnGameInitialized;
        }

        // when the game starts up
        private void OnGameInitialized(object sender, EventArgs e)
        {
            // code
        }

        // What happens every frame 
        private void Update()
        {
            // code
        }

        private void FixedUpdate()
        {
            // code
        }

        // If you want a GUI
        private void OnGUI()
        {
            // code
        }
    }
}