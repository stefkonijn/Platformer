using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{

    /// <summary>
    /// Fired when a Player collides with spikes.
    /// </summary>
    /// <typeparam name="EnemyCollision"></typeparam>
    public class SpikesCollision : Simulation.Event<SpikesCollision>
    {
        public PlayerController player;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void ExecuteAsync()
        {  

            {
                Schedule<PlayerDeath>();
            }
        }
    }
}