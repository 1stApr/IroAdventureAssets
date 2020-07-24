using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
namespace Platformer.Gameplay
{

    /// <summary>
    /// This event is triggered when the player character enters a trigger with a VictoryZone component.
    /// </summary>
    /// <typeparam name="PlayerEnteredVictoryZone"></typeparam>
    
    public class PlayerEnteredVictoryZone : Simulation.Event<PlayerEnteredVictoryZone>
    {
        public VictoryZone victoryZone;
        

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        

        public override void Execute()
        {
            model.player.animator.SetTrigger("victory");
            model.player.controlEnabled = false;
            Score.isVictory = 1;
            //
            int numTemp = Score.score;
            PlayerPrefs.SetInt("ScoreNumber", numTemp);
            Debug.Log("Save Score " + numTemp);

            if (LoadScore.p[0] < numTemp)
            {
                PlayerPrefs.SetInt("ps0", numTemp);
                LoadScore.loadScore();
            }
            
        }
    }
}