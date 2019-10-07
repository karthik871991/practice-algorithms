namespace AlgoPractice
{
    public class GameOfLife289
    {
        public void GameOfLife(int[][] board)
        {
            var result = new int[board.Length][];

            for (int i = 0; i < board.Length; i++)
            {
                result[i] = new int[board[i].Length];

                for (int j = 0; j < board[i].Length; j++)
                {
                    result[i][j] = board[i][j];

                    var lives = GetNumberOfLives(i, j, board.Length, board[i].Length, board);

                    if (board[i][j] == 1 && !(lives >= 2 && lives <= 3))
                    {
                        result[i][j] = 0;
                    }

                    if (board[i][j] == 0 && lives == 3)
                    {
                        result[i][j] = 1;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[0].Length; j++)
                {
                    board[i][j] = result[i][j];
                }
            }
        }

        private int GetNumberOfLives(int i, int j, int row, int col, int[][] board)
        {
            int lives = 0;

            if (IsInsideBoundary(i, j + 1, row, col) && board[i][j + 1] == 1)
                lives++;

            if (IsInsideBoundary(i, j - 1, row, col) && board[i][j - 1] == 1)
                lives++;

            if (IsInsideBoundary(i + 1, j + 1, row, col) && board[i + 1][j + 1] == 1)
                lives++;

            if (IsInsideBoundary(i + 1, j - 1, row, col) && board[i + 1][j - 1] == 1)
                lives++;

            if (IsInsideBoundary(i - 1, j + 1, row, col) && board[i - 1][j + 1] == 1)
                lives++;

            if (IsInsideBoundary(i - 1, j - 1, row, col) && board[i - 1][j - 1] == 1)
                lives++;

            if (IsInsideBoundary(i + 1, j, row, col) && board[i + 1][j] == 1)
                lives++;

            if (IsInsideBoundary(i - 1, j, row, col) && board[i - 1][j] == 1)
                lives++;

            return lives;
        }

        private bool IsInsideBoundary(int i, int j, int r, int c)
        {
            if (i < 0 || i >= r || j < 0 || j >= c)
                return false;

            return true;
        }
    }
}
