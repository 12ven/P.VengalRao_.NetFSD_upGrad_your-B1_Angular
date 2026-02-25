
let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];


let passed = students.filter(s => s.marks >= 40);
console.log("Passed Students:", passed);


let distinction = students.filter(s => s.marks >= 85);
console.log("Distinction Students:", distinction);


let avg = students.reduce((sum, s) => sum + s.marks, 0) / students.length;
console.log("Class Average:", avg.toFixed(2));


let topper = students.reduce((max, s) => s.marks > max.marks ? s : max, students[0]);
console.log("Topper:", topper);


let failedCount = students.filter(s => s.marks < 40).length;
console.log("Failed Students Count:", failedCount);


let graded = students.map(s => {
  let grade;
  if (s.marks >= 85) grade = "A";
  else if (s.marks >= 60) grade = "B";
  else if (s.marks >= 40) grade = "C";
  else grade = "Fail";
  return { ...s, grade };
});
console.log("Grades:", graded);


let ranked = [...students].sort((a, b) => b.marks - a.marks)
  .map((s, index) => ({ ...s, rank: index + 1 }));
console.log("Ranked Students:", ranked);


let lowest = students.reduce((min, s) => s.marks < min.marks ? s : min, students[0]);
students = students.filter(s => s !== lowest);
console.log("Removed lowest scorer:", lowest);
console.log("Remaining Students:", students);


let leaderboard = [...students].sort((a, b) => b.marks - a.marks);
console.log("Leaderboard:", leaderboard);