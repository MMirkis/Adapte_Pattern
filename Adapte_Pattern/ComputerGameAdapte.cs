using Adapte_Pattern.Game_Description;
using Adapte_Pattern.Interfices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapte_Pattern
{
    public class ComputerGameAdapter : PCGame
    {
        private ComputerGame computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        public string getTitle()
        {
            return computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            
            return (int)computerGame.getPegiAgeRating() switch
            {
                (int)PegiAgeRating.P3 => 3,
                (int)PegiAgeRating.P7 => 7,
                (int)PegiAgeRating.P12 => 12,
                (int)PegiAgeRating.P16 => 16,
                (int)PegiAgeRating.P18 => 18,
                _ => 0 
            };
        }

        public bool isTripleAGame()
        {
            
            return computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            
            return new Requirements(
                computerGame.getMinimumGpuMemoryInMegabytes() / 1024, 
                computerGame.getDiskSpaceNeededInGB(),
                computerGame.getRamNeededInGb(),
                computerGame.getCoreSpeedInGhz(),
                computerGame.getCoresNeeded()
            );
        }
    }
}
