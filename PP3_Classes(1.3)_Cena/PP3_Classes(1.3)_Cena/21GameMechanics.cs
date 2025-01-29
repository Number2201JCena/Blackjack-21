using System;
using _2Y_OOP_2324_ADeckOfCards;

namespace PP3_Classes_1._3__Cena
{
	internal class _1GameMechanics
	{
        static DeckOfCards _doc = new DeckOfCards(true);

        public int Introduction()
		{
			string Choice = "";
			int PlayerFinalScore = 0;
			Console.WriteLine("Welcome to a game of 21! Here, your goal is to get as close or exactly to 21" +
				" without going past 21.");
			Console.WriteLine("You have 2 options: Draw a card or stopping. Drawing will draw a random card from a standard 52-card" +
				" deck while stopping will stop the game at the current state.");
			Console.WriteLine("To begin, press D.");
			Console.WriteLine("(D)raw or (S)top?");
			Choice = Console.ReadLine().ToUpper();


            if (Choice == "D")
            {
                PlayerFinalScore = DrawOrStop(Choice);
            }
            else
            {
                Console.WriteLine("Error Found! Please Press a Key to Try Again.");
                Console.ReadKey();
                Console.Clear();
                Introduction();
            }
			return PlayerFinalScore;
		}

		private int DrawOrStop(string Decision)
		{
			string NextMove = "";
			bool Proceed = true;
			bool Over21 = false;
			int CurrentPoints = 0;
			int FinalPoints = 0;
			while (Proceed)
			{
				if (Over21 == true)
				{
					Proceed = false;
					break;
				}


                if (Decision == "D")
                {
					CurrentPoints = CardDrawer();

					if (CurrentPoints + FinalPoints <= 21)
					{
						FinalPoints += CurrentPoints;
					}
					else
					{
						FinalPoints = 0;
						Over21 = true;
						break;
					}
                }
                else if (Decision == "S")
                {
					break;
                }


				if(Over21)
				{
					break;
				}
				else
				{
					Console.WriteLine("Your score is " + FinalPoints + " over 21.");
                    Console.WriteLine("The chosen move has been fully completed. What's your next move: (D)raw or (S)top?");
                    NextMove = Console.ReadLine().ToUpper();
                    Proceed = ContinueOrStop(NextMove);
                }
			}

			Console.Clear();
			Console.WriteLine("The game has been stopped.");
		
			return FinalPoints;
			
		}

		private bool ContinueOrStop(string NextMove)
		{
			bool Continue = true;

            if (NextMove == "D")
            {
				Continue = true;
            }
            else if (NextMove == "S")
            {
				Continue = false;
            }

			return Continue;
        }

        private int CardDrawer()
        {
            int CardPointValue = 0;
            DeckOfCards doc = new DeckOfCards(true);
            Card draw = doc.drawACard();
            List<Card> CurrentCard = new List<Card>();


			CurrentCard = doc.drawACard(1);

			foreach(Card c in CurrentCard)
			{
				CardPointValue = c.GetCardValue();
			}
			Console.WriteLine("The card you drew had a value of: " + CardPointValue);
            return CardPointValue;
        }
    }

}

