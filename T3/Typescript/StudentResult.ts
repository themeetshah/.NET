type StudentBasic = [number, string];

type Student = {
    basic: StudentBasic;
    marks: string[];
    remarks: string | null;
}

function calculateAverage(marks: number[]): number {
    let sum = marks.reduce((sum, mark) => sum + mark, 0);
    return sum / marks.length;
}

function isPassed(average: number): boolean {
    return average >= 40;
}

function generateResult(student: Student): string {
    const [id, name] = student.basic;
    const average = calculateAverage(student.marks.map(m => Number(m)));
    const passed = isPassed(average);
    const remarks = passed ? "Passed" : "Failed";
    return `ID: ${id}, Name: ${name}, Average: ${average.toFixed(2)}, Result: ${remarks}`;
}

const student1: Student = {
    basic: [1, "ABC"],
    marks: ['85', '90', '78'],
    remarks: null
};
const student2: Student = {
    basic: [2, "XYZ"],
    marks: ['30', '25', '28'],
    remarks: null
};
console.log(generateResult(student1)); // Student ID: 1, Name: Alice, Average Marks: 84.33, Result: Passed
console.log(generateResult(student2)); // Student ID: 2, Name: Bob, Average Marks: 27.67, Result: Failed