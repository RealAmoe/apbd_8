using Exercise6;

            // Test Task1
            var task1Result = LinqTasks.Task1();
            Console.WriteLine("Task1:");
            foreach (var emp in task1Result)
            {
                Console.WriteLine($"{emp.Empno} {emp.Ename} {emp.Job} {emp.Salary}");
            }

            // Test Task2
            var task2Result = LinqTasks.Task2();
            Console.WriteLine("\nTask2:");
            foreach (var emp in task2Result)
            {
                Console.WriteLine($"{emp.Empno} {emp.Ename} {emp.Job} {emp.Salary}");
            }

            // Test Task3
            var task3Result = LinqTasks.Task3();
            Console.WriteLine("\nTask3:");
            Console.WriteLine(task3Result);

            // Test Task4
            var task4Result = LinqTasks.Task4();
            Console.WriteLine("\nTask4:");
            foreach (var emp in task4Result)
            {
                Console.WriteLine($"{emp.Empno} {emp.Ename} {emp.Job} {emp.Salary}");
            }

            // Test Task5
            var task5Result = LinqTasks.Task5();
            Console.WriteLine("\nTask5:");
            foreach (var emp in task5Result)
            {
                Console.WriteLine(emp);
            }

            // Test Task6
            var task6Result = LinqTasks.Task6();
            Console.WriteLine("\nTask6:");
            foreach (var emp in task6Result)
            {
                Console.WriteLine(emp);
            }

            // Test Task7
            var task7Result = LinqTasks.Task7();
            Console.WriteLine("\nTask7:");
            foreach (var jobGroup in task7Result)
            {
                Console.WriteLine(jobGroup);
            }

            // Test Task8
            var task8Result = LinqTasks.Task8();
            Console.WriteLine("\nTask8:");
            Console.WriteLine(task8Result);

            // Test Task9
            var task9Result = LinqTasks.Task9();
            Console.WriteLine("\nTask9:");
            Console.WriteLine($"{task9Result.Empno} {task9Result.Ename} {task9Result.Job} {task9Result.Salary}");

            // Test Task10
            var task10Result = LinqTasks.Task10();
            Console.WriteLine("\nTask10:");
            foreach (var emp in task10Result)
            {
                Console.WriteLine(emp);
            }

            // Test Task11
            var task11Result = LinqTasks.Task11();
            Console.WriteLine("\nTask11:");
            foreach (var dept in task11Result)
            {
                Console.WriteLine(dept);
            }

            // Test Task12
            var task12Result = LinqTasks.Task12();
            Console.WriteLine("\nTask12:");
            foreach (var emp in task12Result)
            {
                Console.WriteLine($"{emp.Empno} {emp.Ename} {emp.Job} {emp.Salary}");
            }

            // Test Task13
            int[] arr = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            var task13Result = LinqTasks.Task13(arr);
            Console.WriteLine("\nTask13:");
            Console.WriteLine(task13Result);

            // Test Task14
            var task14Result = LinqTasks.Task14();
            Console.WriteLine("\nTask14:");
            foreach (var dept in task14Result)
            {
                Console.WriteLine($"{dept.Deptno} {dept.Dname} {dept.Loc}");
            }
