using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MathNet.Symbolics;
using System.Reflection;



using Microsoft.VisualBasic;

namespace Lab1
{
    interface IView
    {
        string returnFunction();
        double lowLimit();
        double upLimit();
        double Interval();
        double firstSide();
        double secondSide();
        double epsilon();

        bool MinimumOrMaximum();
        void ShowGraph(PlotModel plotModel);
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
        event EventHandler<EventArgs> CreateGraph;
        event EventHandler<EventArgs> StartGoldenRatio;
    }


    // Модель. Основная часть работы программы происходит здесь
    class Model
    {
        public PlotModel CreateGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            //Expression expression = new Expression(); 
            //Function Function;
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
            double xIntercept = double.NaN;
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "График функции f(x)" };


            var dataPoints = new List<double> { 0 };


            var absicc = new LineSeries {
                Title = "Абсцисс",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-limit, 0));
            absicc.Points.Add(new DataPoint(limit, 0));

            var ordinate = new LineSeries {
                Title = "Ординат",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, limit));
            ordinate.Points.Add(new DataPoint(0, -limit));

            // Создаем серию точек графика
            var lineSeries = new LineSeries {
                Title = "f(x)",
                Color = OxyColor.FromRgb(0, 0, 255) // Синий цвет линии
            };

            var Function = Infix.ParseOrThrow(function);

            //expression = new Expression($"f({1})", Function);
            int lowIndex = Convert.ToInt32(functionLimit);
            int upIndex = Convert.ToInt32(upFunctionLimit);
            for (int counterI = -lowIndex; counterI <= upIndex; ++counterI)
            {
                FloatingPoint x1 = counterI;
                var variables = new Dictionary<string, FloatingPoint>
                {
                     { "x", x1 }
                };
                var y = Evaluate.Evaluate(variables, Function).RealValue;
                lineSeries.Points.Add(new DataPoint(counterI, y));
            }

            // Добавляем все точки в серию
            lineSeries.Points.AddRange(dot);

            // Добавляем серию точек к модели графика
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return plotModel;
        }

        public (double, double) Dichotomy(string inputFunction, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = double.NaN;
            double currentResult = 0;
            double errorCheck = 0;

            var function = Infix.ParseOrThrow(inputFunction);

            FloatingPoint leftLimit = leftLimitation;
            var left = new Dictionary<string, FloatingPoint>
            {
                     { "x", leftLimit }
            };

            var leftY = Evaluate.Evaluate(left, function).RealValue;

            FloatingPoint rightLimit = rightLimitation;
            var right = new Dictionary<string, FloatingPoint>
            {
                     { "x", rightLimit }
            };

            var rightY = Evaluate.Evaluate(right, function).RealValue;


            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                FloatingPoint temp = currentResult;
                var middle = new Dictionary<string, FloatingPoint>
                {
                     { "x", temp }
                };
                double position = Evaluate.Evaluate(middle, function).RealValue;

                if (Math.Abs(position) == 0) // Найден точный корень
                {
                    result = currentResult;
                    return (result, errorCheck);
                }
                else if (rightY * position < 0) // Корень в левой половине интервала
                {
                    rightLimitation = currentResult;
                    rightLimit = rightLimitation;
                    right = new Dictionary<string, FloatingPoint>
                    {
                         { "x", rightLimit }
                    };

                    rightY = Evaluate.Evaluate(right, function).RealValue;
                }
                else // Корень в правой половине интервала
                {
                    leftLimitation = currentResult;
                    leftLimit = leftLimitation;
                    left = new Dictionary<string, FloatingPoint>
                    {
                          { "x", leftLimit }
                    };

                    leftY = Evaluate.Evaluate(left, function).RealValue;
                }
            }

            result = currentResult;

            if (leftY * rightY > 0)
            {
                errorCheck = 1;
            }
            else
            {
                errorCheck = 0;
            }

            return (result, errorCheck);
        }

        public (double, double) GoldenRatio(string inputExpression, double leftLimitation, double rightLimitation, double epsilon, bool choice = true)
        {
            double result = double.NaN;
            double functionResult = 0;
            Expression function;
            if (!choice)
            {
                string str = "-(" + inputExpression + ")";
                function = Infix.ParseOrThrow(str);
            }
            else
            {
                function = Infix.ParseOrThrow(inputExpression);
            }

            FloatingPoint leftLimit = leftLimitation;
            var left = new Dictionary<string, FloatingPoint>
            {
                     { "x", leftLimit }
            };

            var leftY = Evaluate.Evaluate(left, function).RealValue;

            FloatingPoint rightLimit = rightLimitation;
            var right = new Dictionary<string, FloatingPoint>
            {
                     { "x", rightLimit }
            };

            var rightY = Evaluate.Evaluate(right, function).RealValue;

            double goldenRatio = (Math.Sqrt(5) - 1) / 2;

            double xFirst = rightLimitation - goldenRatio * (rightLimitation - leftLimitation);
            double xSecond = leftLimitation + goldenRatio * (rightLimitation - leftLimitation);

            FloatingPoint firstX = xFirst;
            var CreateXFirst = new Dictionary<string, FloatingPoint>
            {
                     { "x", firstX }
            };
            var resultOfXFirst = Evaluate.Evaluate(CreateXFirst, function).RealValue;

            FloatingPoint secondX = xSecond;
            var CreateXSecond = new Dictionary<string, FloatingPoint>
            {
                     { "x", secondX }
            };
            var resultOfXSecond = Evaluate.Evaluate(CreateXSecond, function).RealValue;


            while (Math.Abs(rightLimitation - leftLimitation) > epsilon)
            {
                if (resultOfXFirst < resultOfXSecond)
                {
                    rightLimitation = xSecond;
                    xSecond = xFirst;
                    xFirst = rightLimitation - goldenRatio * (rightLimitation - leftLimitation);
                    firstX = xFirst;
                    CreateXFirst = new Dictionary<string, FloatingPoint>
                    {
                          { "x", firstX }
                    };
                    resultOfXFirst = Evaluate.Evaluate(CreateXFirst, function).RealValue;
                    secondX = xSecond;
                    CreateXSecond = new Dictionary<string, FloatingPoint>
                    {
                            { "x", secondX }
                    };
                    resultOfXSecond = Evaluate.Evaluate(CreateXSecond, function).RealValue;
                }
                else
                {
                    leftLimitation = xFirst;
                    xFirst = xSecond;
                    xSecond = leftLimitation + goldenRatio * (rightLimitation - leftLimitation);
                    CreateXFirst = new Dictionary<string, FloatingPoint>
                    {
                          { "x", firstX }
                    };
                    resultOfXFirst = Evaluate.Evaluate(CreateXFirst, function).RealValue;
                    secondX = xSecond;
                    CreateXSecond = new Dictionary<string, FloatingPoint>
                    {
                            { "x", secondX }
                    };
                    resultOfXSecond = Evaluate.Evaluate(CreateXSecond, function).RealValue;
                }
            }
            result = (leftLimitation + rightLimitation) / 2;
            FloatingPoint resultX = result;
            var CreateResult = new Dictionary<string, FloatingPoint>
            {
                     { "x", resultX }
            };
            functionResult = Evaluate.Evaluate(CreateResult, function).RealValue;

            return (result, functionResult);
        }

        //public (double,double) Newton(string inputFunction, double inputApproximation, double epsilon)
        //{
        //    var function = Infix.PareseOrThrow
        //}

    }

    // Презентер. Извлекает данные из модели, передает в вид. Обрабатывает события
    class Presenter
    {
        private IView mainView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();

            mainView.StartDichotomy += new EventHandler<EventArgs>(Dichotomy);
            mainView.CreateGraph += new EventHandler<EventArgs>(CreateGraph);
            mainView.StartGoldenRatio += new EventHandler<EventArgs>(GoldenRatio);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
        private void CreateGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateGraph(mainView.Interval(), mainView.lowLimit(), mainView.upLimit(), mainView.returnFunction());
            mainView.ShowGraph(output);
        }

        private void GoldenRatio(object sender, EventArgs inputEvent)
        {
            var output = model.GoldenRatio(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

