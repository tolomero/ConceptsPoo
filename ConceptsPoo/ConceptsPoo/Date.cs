using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    //#1 crear class Date
    public class Date
    {
        ////#2 declarar varibles a usar
        //private int _year;
        //private int _month;
        //private int _day;

        ////#3 contruir el constructore snipet ctor he instanciarlo
        //public Date(int year, int month, int day)
        //{
        //    _year = year;
        //    _month = CheckMonth(month);
        //    _day = day;
        //}
        ////#7 crear el metodo CheckMonth
        //private int CheckMonth(int month)
        //{
        //    if (month >= 1 && month <= 12)
        //    {
        //        return month;
        //    }
        //    throw new MonthException("Invalid Month");
        //}

        ////#6 se hace el overrride para que solo muestre la info date en string
        //public override string ToString()
        //{
        //   return $"{_year}/{_month:00}/{_day:00}";

        //}

        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            //si se le pone el underline ya no necesita el this
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }



        //toca validar si es bisiesto el year
        //en la linea 34 es donde validamos que el dia tiene q ser mayor igual a uno y que el dia se menor igual que los dias que debe tener el mes
        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeepYear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new DayException("Invalid day");

        }

        //toca comprobar si el year es modulo de 4 multiplo y es diferente de 100 es bisiesto y si es multiplo de 400 tambien
        private bool IsLeepYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //if (year % 4 == 0)
            //{
            //    if(year % 100 == 0)
            //    {
            //        if(year % 400 == 0)
            //            {
            //            return true;
            //            }
            //        else
            //        {
            //            return false;
            //        }

            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }
        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("Invalid month");
        }

        //metodo de sobre escritura con espacio me muestra todos lo metodos que son suseptibles a sobre escritura
        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
