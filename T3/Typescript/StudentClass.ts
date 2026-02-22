class Student {
    constructor(public roll_no: number, public name: string, public course: string, public isPaid: boolean) { }

    checkFeeStatus(): string {
        return this.isPaid ? "Fee Paid" : "Fee Not Paid";
    }
}

const student1 = new Student(1, "ABC", "B.Tech", true);
const student2 = new Student(2, "XYZ", "B.Sc", false);

console.log(`Student: ${student1.name}, Roll No: ${student1.roll_no}, Course: ${student1.course}, Fee Status: ${student1.checkFeeStatus()}`);
console.log(`Student: ${student2.name}, Roll No: ${student2.roll_no}, Course: ${student2.course}, Fee Status: ${student2.checkFeeStatus()}`);