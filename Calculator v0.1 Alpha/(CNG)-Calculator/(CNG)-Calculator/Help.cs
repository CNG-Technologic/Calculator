using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class Help
    {
        public void Can()
        {
            startMain start = new startMain();
            Console.WriteLine("<+> - Сумма" +
                "\n<-> - Разность" +
                "\n<*> - Умножение" +
                "\n</> - Деление" +
                "\n<1> || <Step> - Степени" +
                "\n<2> || <Ko>- Корни" +
                "\n<3> - Синусы" +
                "\n<4> - Косинусы" +
                "\n<5> - Тангенсы" +
                "\n<6> - Котангенсы" +
                "\n<7> - Факториал" +
                "\n<8> - Квадратное Уравнение" +
                "\n<9> - Нахождение сторон Прям.Треугольника(Теорема Пифагора)" +
                "\n<10> - Переводы чисел из разных систем счесления");
            Console.WriteLine("");
            start.startM();
        }
    }
}
