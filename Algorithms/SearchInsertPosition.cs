// Source : https://leetcode.com/problems/search-insert-position/ 
// Author : codeyu 
// Date : Monday, October 17, 2016 7:37:43 PM 

/**********************************************************************************
*
* Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
* 
* You may assume no duplicates in the array.
* 
* 
* Here are few examples.
* [1,3,5,6], 5 &#8594; 2
* [1,3,5,6], 2 &#8594; 1
* [1,3,5,6], 7 &#8594; 4
* [1,3,5,6], 0 &#8594; 0
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution035 
    {
        public static int SearchInsert(int[] nums, int target) 
        {
            if(nums != null && nums.Length > 0)
            {
                var left = 0;
                var right = nums.Length - 1;
                while(left <= right)
                {
                    var mid = left + (right - left) / 2;
                    if(nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                if(left > right)
                {
                    return left;
                }
                return left == 0 ? 0 : nums.Length;
                
            }
            return -1;  
        }
    }
}

