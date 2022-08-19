using System;

namespace TextEditor
{
    public static class Ansi
    {
        private static char ESC = '\u001b';

        public static readonly string 
            cursorhome = $"{ESC}[H",
            cursorsave= $"{ESC}7",
            cursorload= $"{ESC}8",
            cursorgetpos= $"{ESC}[6n";

        public static string Cursorset(int x = 0, int y = 0) { return $"{ESC}[{y};{x}H";}
        public static string Cursorsetcol(int x = 0) { return $"{ESC}[{x}G"; }
        public static string Cursormove(int x = 0, int y = 0) {
            return $"{ESC}[{Math.Abs(x)}{(x > 0 ? "C" : "D")}{ESC}[{Math.Abs(y)}{(y > 0 ? "E" : "F")}"; 
        }

        public static readonly string
            clear = $"{ESC}[2J",

            reset = $"{ESC}[0m",
            bold = $"{ESC}[1m",
            dim = $"{ESC}[2m",
            italics = $"{ESC}[3m",
            underline = $"{ESC}[4m",
            blinking = $"{ESC}[5m",
            inverse = $"{ESC}[7m",
            hidden = $"{ESC}[8m",
            strikethrough = $"{ESC}[9m",
            dblunderline = $"{ESC}[21m",

            rst = $"{ESC}[0m",
            bld = $"{ESC}[1m",
            itl = $"{ESC}[3m",
            udl = $"{ESC}[4m",
            blk = $"{ESC}[5m",
            inv = $"{ESC}[7m",
            hdn = $"{ESC}[8m",
            stk = $"{ESC}[9m",


            unbold = $"{ESC}[22m",
            undim = $"{ESC}[22m",
            unitalics = $"{ESC}[23m",
            ununderline = $"{ESC}[24m",
            unblinking = $"{ESC}[25m",
            uninverse = $"{ESC}[27m",
            unhidden = $"{ESC}[28m",
            unstrikethrough = $"{ESC}[29m";


        public static string C256(int color, bool foreground = true)
        {
            return $"{ESC}[{(foreground ? 38 : 48)};5;{color}";
        }


        public static string Rgb(int r, int g, int b, bool foreground=true)
        {
            return $"{ESC}[{(foreground ? 38: 48)};2;{r};{g};{b}";
        }

    }
}
