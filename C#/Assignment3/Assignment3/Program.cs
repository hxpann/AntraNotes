using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3;

var _at = new AccomplishTask();

int[] numbers = _at.GenerateNumbers();
_at.Reverse(numbers);
_at.PrintNumbers(numbers);



