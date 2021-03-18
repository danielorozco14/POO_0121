package MAR22.JV;

public class Main {

    public class Employee {
        private String employeeName;
        private float salary;

        public String getEmployeeName() {
            return employeeName;
        }

        public void setEmployeeName(String name) {
            this.employeeName = name;
        }

        public float getSalary() {
            return salary;
        }

        public void setSalary(float salary) {
            this.salary = salary;
        }

        public Employee() {
        }// Constructor

        public float calculateSalary() {
            return (getSalary() - (getSalary() * 0.03f) - (getSalary() * 0.0625f));
        }
    }

    public class Accountant extends Employee {

        @Override
        public float calculateSalary() {
            return (getSalary() - (getSalary() * 0.10f) - (getSalary() * 0.03f) - (getSalary() * 0.0625f));
        }

        public Accountant() {
        } // Constructor

        public Accountant(float salary) {
            setSalary(salary);
        }

        @Override
        public String toString() {
            return ("Accountant Info: \n\t" + "Name: " + getEmployeeName() + "\n" + "\tSalary: " + calculateSalary());
        }
    }

    public static void main(String[] args) {
        Main main = new Main();
        Main.Accountant accountant = main.new Accountant(1550f);
        accountant.setEmployeeName("Daniel Orozco");
        System.out.println(accountant.toString());
    }
}
