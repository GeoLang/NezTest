using Microsoft.Xna.Framework;
using Nez;

namespace NezTest.Desktop
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {

        public Game1() : base()
        {}

        protected override void Initialize()
        {
            base.Initialize();
            // var scene = Scene.create(Color.CornflowerBlue);
            var scene = Scene.CreateWithDefaultRenderer(Color.CornflowerBlue);
            

            Core.Scene = scene;
        }
    }
}
