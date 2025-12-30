/*Array is the reference type variable
To declare the arry

datatype[] array name;

eg int[] store;

how to initialise the array
Score = new int[10];

this is the two liner , we can do it in one liner approach

int[] score = new int[10]; // This is the same as the java approach

The index of the array begins with the zero

eg. int[] score = new int[9];
Score[0]=5;

automatic array size then
int [] Score = {5,10,15}; This is giving use the flexibility to decide the size
at the run time.

alsp

int [] score = new int[9]{0,1,2,3,4,5,,7,8,9}; This is going to work in C#.
new way but not in java;

also at the run time
int[] score = new int[]{0,1,2,3,4,5,,7,8,9}; // we got the flexibility again
to decide the size at the run time and run time giving the elements

The array is the reference type. The starting element of array , memory locatiion
is held by the name of the array,

eg. int[] Source = new int[10]{0,1,2,3,4};
int target[] = source;

now the target will refer to the source array.
target[0] = source[0];

we can also maipulate the array in the memory by both the target and the source
The array content can be done the logical , arithematic operations.

How to manipulate the array:

using System; //program is the palindrome number eg RACECAR MADAM RADAR MALAYALAM

namespace ManipulateArray{
    //1. what is the length of the particular word, use the array_Name.length property
    class Palindrome{
        static void main(String[] args){
            char[] str = new char[]{'R','A','C','E','C','A','R'};
            //or Str = Console.ReadLine().ToCharArray();

            Console.WriteLine(CheckPalindrome(str));
            
        }
        private static bool CheckPalindrome(char[] myString){
            //returns true or false.

            int startchar=0, lastchar=0;
            lastchar = myString.Length-1;
            while(startchar < lastchar){
                if(myString[startchar]==myString[lastchar]){
                    startchar++;
                    lastchar--;
                }
                else{
                    return false;
                }
            }
            return true;

        }
    }

}

*/