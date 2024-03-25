namespace Tic_Tac_Toe.Entities
{
    /** ************************************************************************
    * \brief Information about the palyer.
    * \details This class contains all configurations abouth the player.
    * \author Thiago Sérvulo Guimarães - thiagoservulog@gmail.com
    * \date 25/03/2024
    * \version v1.1.0
    ***************************************************************************/
    class Player
    {
        /// \brief Number of victories.
        public int Victories { get; set; }

        /// \brief Number of draws.
        public int Draws { get; set; }

        /// \brief Symbol of the player.
        public char Symbol { get; set; }

        /// \brief Color of the player.
        public string Color { get; set; }

        /** ************************************************************************
        * \brief Constructor for creating a Player object.
        * \details Initializes a Player object with the provided victory count, draw
        * count, symbol, and color.
        * \param victories The number of victories for the player.
        * \param draws The number of draws for the player.
        * \param symbol The symbol representing the player.
        * \param color The color associated with the player.
        ***************************************************************************/
        public Player(int victories, int draws, char symbol, string color)
        {
            Victories = victories;
            Draws = draws;
            Symbol = symbol;
            Color = color;
        }

        /** ************************************************************************
        * \brief Increments the victory count for the player.
        * \details Increases the number of victories for the player by one.
        ***************************************************************************/
        public void AddVictory()
        {
            ++Victories;
        }

        /** ************************************************************************
        * \brief Increments the draw count for the player.
        * \details Increases the number of draws for the player by one.
        ***************************************************************************/
        public void AddDraw()
        {
            ++Draws;
        }
    }
}
