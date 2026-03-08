let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let uniqueNumbers = [...new Set(numbers)];
console.log("Unique Numbers:", uniqueNumbers);


let sortedUnique = [...uniqueNumbers].sort((a, b) => b - a);
let secondLargest = sortedUnique[1];
console.log("Second Largest Number:", secondLargest);


let frequency = numbers.reduce((acc, num) => {
  acc[num] = (acc[num] || 0) + 1;
  return acc;
}, {});
console.log("Frequency:", frequency);


let firstNonRepeating = numbers.find(num => frequency[num] === 1);
console.log("First Non-Repeating Number:", firstNonRepeating);


let rotated = numbers.slice(2).concat(numbers.slice(0,2));
console.log("Array Rotated by 2:", rotated);


let nested = [1,2,[3,4,[5]]];
let flattened = nested.flat(2);
console.log("Flattened Array:", flattened);


let arr = [1,2,3,5,6];
let missing = arr.reduce((acc, val, idx) => {
  if (val !== idx+1) acc = idx+1;
  return acc;
}, null);
console.log("Missing Number:", missing);