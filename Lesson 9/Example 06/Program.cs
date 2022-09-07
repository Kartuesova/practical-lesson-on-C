// Написать программу возведения числа А в целую стень B

  Console.Write("Введите число A  : ");
  int num = int.Parse(Console.ReadLine());
  Console.Write("Введите степень B: ");
  int n = int.Parse(Console.ReadLine());
  int num_n=1;
  for(int i=0; i<n; i++) {
   num_n*=num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  Console.ReadKey();
  return 0;