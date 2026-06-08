using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_calc
{
    internal class GraphicUtils
    {
        /// <summary>
        /// Handles formatting text and manipulating the cursor in the console.
        /// </summary>
        public static class ConsoleFormatter
        {
            /// <summary>
            /// Set the text foreground color to the given RGB values.
            /// </summary>
            /// <param name="r"></param>
            /// <param name="g"></param>
            /// <param name="b"></param>
            public static void ForegroundColor(int r, int g, int b)
            {
                Console.Write($"\u001b[38;2;{r};{g};{b}m");
            }

            /// <summary>
            /// Set the text background color to the given RGB values.
            /// </summary>
            /// <param name="r"></param>
            /// <param name="g"></param>
            /// <param name="b"></param>
            public static void BackgroundColor(int r, int g, int b)
            {
                Console.Write($"\u001b[48;2;{r};{g};{b}m");
            }

            /// <summary>
            /// Enable bold text.
            /// </summary>
            public static void Bold()
            {
                Console.Write("\x1b[1m");
            }

            /// <summary>
            /// Enable dim text.
            /// </summary>
            public static void Dim()
            {
                Console.Write("\x1b[2m");
            }

            /// <summary>
            /// Enable italic text.
            /// </summary>
            public static void Italic()
            {
                Console.Write("\x1b[3m");
            }

            /// <summary>
            /// Enable underlined text.
            /// </summary>
            public static void Underline()
            {
                Console.Write("\x1b[4m");
            }

            /// <summary>
            /// Enable blinking text.
            /// </summary>
            public static void Blink()
            {
                Console.Write("\x1b[5m");
            }

            /// <summary>
            /// Invert foreground and background colors.
            /// </summary>
            public static void Invert()
            {
                Console.Write("\x1b[7m");
            }

            /// <summary>
            /// Enable strikethrough text.
            /// </summary>
            public static void Strikethrough()
            {
                Console.Write("\x1b[9m");
            }

            /// <summary>
            /// Clear the console and optionally the scroll buffer.
            /// </summary>
            /// <param name="scrollBuffer"></param>
            public static void Clear(bool scrollBuffer = true)
            {
                // Move cursor to top-left and clear visible screen
                Console.Write("\x1b[H\x1b[2J");

                // Clear scrollback buffer
                if (scrollBuffer)
                {
                    Console.Write("\x1b[3J");
                }
            }

            /// <summary>
            /// Restore all graphics back to default.
            /// </summary>
            public static void Restore()
            {
                Console.Write($"\u001b[0m");
            }

            /// <summary>
            /// Toggle the visibility of the cursor.
            /// </summary>
            /// <param name="visible"></param>
            public static void SetCursor(bool visible)
            {
                if (visible)
                {
                    Console.Write($"\u001b[?25h");
                }
                else
                {
                    Console.Write($"\u001b[?25l");
                }
            }

            // ┌────────────────────┬───────┐
            // │    Cursor Style    │ Value │
            // ├────────────────────┼───────┤
            // │ Default            │     0 │
            // │ Blinking Block     │     1 │
            // │ Steady Block       │     2 │
            // │ Blinking Underline │     3 │
            // │ Steady Underline   │     4 │
            // │ Blinking Bar       │     5 │
            // │ Steady Bar         │     6 │
            // └────────────────────┴───────┘

            /// <summary>
            /// Set the cursor style.
            /// </summary>
            /// <param name="style"></param>
            /// <exception cref="ArgumentException"></exception>
            public static void SetCursor(int style)
            {
                if (style > 6 || style < 0)
                {
                    throw new InvalidOperationException("Invalid cursor style. Please use a value between 0 and 6.");
                }

                Console.Write($"\u001b[{style} q");
            }
        }
    }
}
