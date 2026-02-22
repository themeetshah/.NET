class BankAccount {
    public account_holder: string;
    private balance: number;

    constructor(account_holder: string, balance: number) {
        this.account_holder = account_holder;
        this.balance = balance;
    }

    deposit(amount: number): void {
        if (amount > 0) {
            this.balance += amount;
            console.log(`Deposited ${amount}. New balance: ${this.balance}`);
        } else {
            console.log(`Deposit amount must be positive : ${amount}.`);
        }
    }

    withdraw(amount: number): void {
        if (amount > 0) {
            if (amount <= this.balance) {
                this.balance -= amount;
                console.log(`Withdrew ${amount}. New balance: ${this.balance}`);
            } else {
                console.log(`Insufficient balance. Current balance: ${this.balance}, attempted withdrawal: ${amount}.`);
            }
        } else {
            console.log(`Withdrawal amount must be positive : ${amount}.`);
        }
    }

    getBalance(): number { return this.balance; }
}

let account1 = new BankAccount("ABC", 1000);
account1.deposit(500);
account1.withdraw(200);
account1.deposit(-500);
account1.withdraw(-200);
account1.withdraw(2200);
console.log("Final balance:", account1.getBalance());