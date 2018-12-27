using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace content
{
    public class BoxDraw
    {
        private static char horizontal = '─';
        private static char vertial = '│';
        private static char bottomLeft = '└';
        private static char bottomRight = '┘';
        private static char topLeft = '┌';
        private static char topRight = '┐';
        public static string Draw(string stringToDraw, int paddingTop = 2, int paddingBottom = 2, int paddingLeft = 2, int paddingRight = 4) 
        {
            IEnumerable<string> lines = stringToDraw.Split(Environment.NewLine);
            if(paddingTop > 0) 
            {
                lines = Enumerable.Range(0, paddingTop).Select(a => string.Empty).Concat(lines);
            }
            if(paddingBottom > 0)
            {
                lines = lines.Concat(Enumerable.Range(0, paddingTop).Select(a => string.Empty));
            }
            var longestLine = lines.Max(a => a.Length);
            var contentWidth = longestLine + paddingLeft + paddingRight;
            var PAD = " ";
            var paddingLeftString = PAD.Repeat(paddingLeft);
            // todo support different margins like centered
            var marginLeft = PAD.Repeat(2);
            var marginTop = Environment.NewLine.Repeat(2);
            var marginBottom = Environment.NewLine.Repeat(2);
            var resultString = new StringBuilder();
            var horizontalString = new String(horizontal, contentWidth);
            var top = marginTop + marginLeft + topLeft + horizontalString + topRight;
            var bottom = marginLeft + bottomLeft + horizontalString + bottomRight + marginBottom;
            var middle = String.Join(Environment.NewLine, lines.Select(line => {
                var paddingRightString = PAD.Repeat(contentWidth - line.Length - paddingLeft);
                return marginLeft + vertial + paddingLeftString + line + paddingRightString + vertial;
            }));
            return top + Environment.NewLine + middle + Environment.NewLine + bottom + Environment.NewLine;
        }
       
    }
}