using System.Collections;
namespace CodeChallenges
{
  public class CodeChallenge1
  {
    public static int[] ReverseArray(int[] array)
    {
      for (int i = 0; i < array.Length / 2; i++)
      {
        int nums = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = nums;
      }
      return array;
    }
  }
}