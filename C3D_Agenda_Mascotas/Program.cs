using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3D_Agenda_Mascotas
{
    class Program
    {
        static double [] Stack = new double[2000];
        static double[] Heap = new double[2000];
        static int P = 0, H = 0;
        static double t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,t11,t12,t13,t14,t15,t16,t17,t18,t19,t20,t21,t22,t23,t24,t25,t26,t27,t28,t29
            ,t30,t31,t32,t33,t34,t35,t36,t37,t38,t39,t40,t41,t42,t43,t44,t45,t46,ta;

        static void Main(string[] args)
        {
            main_principal();
        }

        static void main_principal()
        {
            public_Agenda();
            t21 = P + 2;
            Stack[(int)t21] = t3;
            public_Mascota();
            t22 = P + 3;
            Stack[(int)t22] = t1;
            t23 = P + 3;
            t24 = Stack[(int)t23];
            t25 = t24 + 0;
            t26 = H;
            Heap[H] = (int)'f';
            H = H + 1;
            Heap[H] = (int)'i';
            H = H + 1;
            Heap[H] = (int)'r';
            H = H + 1;
            Heap[H] = (int)'u';
            H = H + 1;
            Heap[H] = (int)'l';
            H = H + 1;
            Heap[H] = (int)'a';
            H = H + 1;
            Heap[H] = (int)'i';
            H = H + 1;
            Heap[H] = (int)'s';
            H = H + 1;
            Heap[H] = 0;
            H = H + 1;
            Heap[(int)t25] = t26;
            t27 = P + 3;
            t28 = Stack[(int)t27];
            t29 = t28 + 0;
            t30 = H;
            Heap[H] = (int)'g';
            H = H + 1;
            Heap[H] = (int)'o';
            H = H + 1;
            Heap[H] = (int)'l';
            H = H + 1;
            Heap[H] = (int)'d';
            H = H + 1;
            Heap[H] = (int)'e';
            H = H + 1;
            Heap[H] = (int)'n';
            H = H + 1;
            Heap[H] = (int)' ';
            H = H + 1;
            Heap[H] = (int)'r';
            H = H + 1;
            Heap[H] = (int)'e';
            H = H + 1;
            Heap[H] = (int)'t';
            H = H + 1;
            Heap[H] = (int)'r';
            H = H + 1;
            Heap[H] = (int)'i';
            H = H + 1;
            Heap[H] = (int)'e';
            H = H + 1;
            Heap[H] = (int)'v';
            H = H + 1;
            Heap[H] = (int)'e';
            H = H + 1;
            Heap[H] = (int)'r';
            H = H + 1;
            Heap[H] = 0;
            H = H + 1;
            Heap[(int)t29] = t30;
            public_Dueno();
            t31 = P + 4;
            Stack[(int)t31] = t2;
            t32 = P + 4;
            t33 = Stack[(int)t32];
            t34 = t33 + 0;
            Heap[(int)t34] = 123;
            t35 = P + 3;
            t36 = Stack[(int)t35];
            t37 = t36 + 2;
            t38 = P + 4;
            t39 = Stack[(int)t38];
            Heap[(int)t37] = t39;
            // llamada a nueva.agregar(m1);
            t40 = P + 2;
            t41 = Stack[(int)t40];
            t42 = P + 5;
            t43 = t42 + 0;
            Stack[(int)t43] = t41;
            t44 = P + 3;
            t45 = Stack[(int)t44];
            t46 = t42 + 2;
            Stack[(int)t46] = t45;
            P = P + 5;
            Agenda_agregar();
            P = P - 5;
        }

        static void public_Mascota()
        {
            t1 = H;
            H = H + 3;
        }

        static void public_Dueno()
        {
            t2 = H;
            H = H + 2;
        }

        static void public_Agenda()
        {
            t3 = H;
            H = H + 2;
            t4 = t3 + 0;
            Heap[(int)t4] = H;
            H = H + 3;
            t5 = t3 + 1;
            Heap[(int)t5] = 0;
        }

        static void Agenda_agregar(){
            t6 = P + 0;
            t7 = Stack[(int)t6];
            t8 = t7 + 1;
            t9 = Heap[(int)t8];
            t10 = P + 2;                // acceder a parametro m, 0 -> this, 1 -> return, 2 -> m   
            t11 = Stack[(int)t10];
            t12 = P + 0;
            t13 = Stack[(int)t12];
            t14 = t13 + 0;
            // accesar por la pos del arreglo
            ta = Heap[(int)t14];
            t15 = t9 + ta;
            Heap[(int)t15] = t11;
            t16 = P + 0;
            t17 = Stack[(int)t16];
            t18 = t17 + 1;
            t19 = Heap[(int)t18];
            t20 = t19 + 1;
            Heap[(int)t18] = t20;
        }
    }
}
