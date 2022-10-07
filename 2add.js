/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]} 
 */
var twoSum = function (nums, target) {
  b = 0;
  a = 1;
  i = nums[a];
  j = nums[b];
  result = [];
  while (b <= nums.length) {
    i = nums[a];
    j = nums[b];
    while (a <= nums.length) {
      i = nums[a];
      j = nums[b];
      if (i + j == target) {
        document.getElementById("result").innerHTML += `${i+j}`;
        result[0] = b;
        result[1] = a;
        return result;
      } else {
        a++;
      }
    }
    b++;
    a = b + 1;
  }
  return result;
};

