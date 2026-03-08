let employees = [
  { id:1, name:"Ravi", dept:"IT", salary:70000 },
  { id:2, name:"Anita", dept:"HR", salary:50000 },
  { id:3, name:"Karan", dept:"IT", salary:80000 },
  { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalExpense = employees.reduce((sum, e) => sum + e.salary, 0);
console.log("Total Salary Expense: ₹" + totalExpense);


let highest = employees.reduce((max, e) => e.salary > max.salary ? e : max, employees[0]);
let lowest = employees.reduce((min, e) => e.salary < min.salary ? e : min, employees[0]);
console.log("Highest Paid Employee:", highest);
console.log("Lowest Paid Employee:", lowest);


let updatedSalaries = employees.map(e =>
  e.dept === "IT" ? { ...e, salary: e.salary * 1.15 } : e
);
console.log("After 15% IT Salary Increase:", updatedSalaries);


let grouped = employees.reduce((acc, e) => {
  acc[e.dept] = acc[e.dept] || [];
  acc[e.dept].push(e);
  return acc;
}, {});
console.log("Grouped by Department:", grouped);


let deptAvg = Object.keys(grouped).map(dept => {
  let avg = grouped[dept].reduce((sum, e) => sum + e.salary, 0) / grouped[dept].length;
  return { dept, avg };
});
console.log("Department-wise Average Salary:", deptAvg);


let sorted = [...employees].sort((a, b) => b.salary - a.salary);
console.log("Employees Sorted by Salary (Desc):", sorted);


let afterTax = employees.map(e => ({ ...e, netSalary: e.salary * 0.9 }));
console.log("After 10% Tax Deduction:", afterTax);


let classAvg = employees.reduce((sum, e) => sum + e.salary, 0) / employees.length;
let aboveAvg = employees.filter(e => e.salary > classAvg);
console.log("Employees Above Average Salary:", aboveAvg);


let htmlTable = "<table border='1'><tr><th>ID</th><th>Name</th><th>Dept</th><th>Salary</th></tr>" +
  employees.map(e => `<tr><td>${e.id}</td><td>${e.name}</td><td>${e.dept}</td><td>${e.salary}</td></tr>`).join("") +
  "</table>";
console.log("HTML Table:\n", htmlTable);