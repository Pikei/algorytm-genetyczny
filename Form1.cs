using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorytm_generyczny
{
    public partial class Form1 : Form
    {
        private int index;
        private int iterations, populationSize, minBound, maxBound, tolerance, after;
        private Dictionary<int, double[]> population = new Dictionary<int, double[]>();
        private Dictionary<int, double[]> parents = new Dictionary<int, double[]>();
        private double[] rating;
        private int[] challengers = new int[3];
        private Random rand = new Random();
        private double[] strongestIndividual;
        private double[] newStrongestIndividual;

        public Form1()
        {
            InitializeComponent();
            this.populacja.Value = 100;
            this.iteracje.Value = 100;
            this.populacja_po_x_iteracjach.Value = 100;
            this.zakresOd.Value = -100;
            this.zakresDo.Value = 100;
        }

        private void createPopulation()
        {
            double[] temp;
            for (int i = 0; i < populationSize; i++)
            {
                temp = generateRandom(minBound, maxBound);
                rating[i] = func(temp);
                population[i] = temp;
            }
        }

        private void start()
        {
            //        printPopulation();
            for (int i = 0; i < (int)iteracje.Value; i++)
            {
                typeNewparents();
                crossingCondition();
                mutateCondition();
                newPopulation();
                strongestIndividualCheck();
                strongestIndividualCondition();
                printAfter(i);
            }

            printEnd();


            printBest();

        }

        private void typeNewparents()
        {
            for (int i = 0; i < populationSize; i++)
            {
                tournament();
                addNewParent(i);
            }
        }

        private void crossingCondition()
        {
            for (int i = 0; i < populationSize; i += 2)
            {
                if (randomCondition() <= 0.4)
                {
                    crossing(i, i + 1);
                }
            }
        }

        private void mutateCondition()
        {
            for (int i = 0; i < populationSize; i++)
            {
                if (randomCondition() <= 0.02)
                {
                    mutate(i);
                    rating[i] = func(parents[i]);
                }
            }
        }

        private void newPopulation()
        {
            foreach (var newPopulation in parents)
            {
                population[newPopulation.Key] = newPopulation.Value;
            }
        }

        private void strongestIndividualCheck()
        {
            newStrongestIndividual = population[tabIndex(rating)];
            if (func(newStrongestIndividual) < func(strongestIndividual))
            {
                population[getKey()] = strongestIndividual;
            }
        }

        private void strongestIndividualCondition()
        {
            if (func(strongestIndividual) <= 1 + tolerance && func(strongestIndividual) >= 1 - tolerance)
            {
                //System.out.println(Arrays.toString(strongestIndividual));
                return;
            }
        }

        private bool indivudual()
        {
            strongestIndividual = population[tabIndex(rating)];
            if (func(strongestIndividual) <= 1 + tolerance && func(strongestIndividual) >= 1 - tolerance)
            {
                return true;
            }
            return false;
        }

        private void addNewParent(int indexOfParent)
        {
            double max = findNewParent();
            foreach (int i in challengers)
            {
                if (rating[i] == max)
                {
                    index = i;
                    break;
                }
            }
            parents[indexOfParent] = population[index];
        }   

        private double findNewParent()
        {
            double[] temp = { rating[challengers[0]], rating[challengers[1]], rating[challengers[2]] };
            return temp.Max();
        }

        private double[] generateRandom(double min, double max)
        {
            double[] temp = new double[4];
            for(int i = 0; i < temp.Length; i++)
            {

                temp[i] = rand.NextDouble() * (max - min) + min;
            }
            return temp;
        }

        private void tournament()
        {
            for (int i = 0; i < challengers.Length; i++)
            {
                challengers[i] = rand.Next(100);
            }
        }

        private double func(double[] x)
        {
            return ((Math.Sin(x[0]) * Math.Cos(x[1])) / (Math.Pow(x[2], 2) * Math.Pow(x[3], 2) + 1)) * -1;
        }

        private double randomCondition()
        {
            return rand.NextDouble();
        }

        private void crossing(int index1, int index2)
        {
            double[] temp1 = { parents[index1][0], parents[index1][1], parents[index2][2], parents[index2][3] };
            double[] temp2 = { parents[index2][0], parents[index2][1], parents[index1][2], parents[index1][3] };
            parents.Remove(index1);
            parents.Remove(index2);
            parents[index1] = temp1;
            parents[index2] = temp2;
        }

        private void mutate(int index)
        {
            for (int i = 0; i < population[index].Length; i++)
            {
                population[index][i] = population[index][i] + (rand.NextDouble() * (0.02 - (-0.02)) + (-0.02));
            }
        }

        private int tabIndex(double[] x)
        {
            double max = x.Max();
            return Array.IndexOf(x, max);
        }

        private int getKey()
        {
            for (int i = 0; i < population.Count; i++)
            {
                if(population[i] == newStrongestIndividual)
                {
                    return i;
                }
            }
            return -1;
        }

        private void printEnd()
        {
            if (koniec.Checked)
            {
               string message = "";
                foreach (var key in population.Keys)
                    message += "\nindex: " + key + " value = [" + String.Join(", ", population[key]) +"]";

                MessageBox.Show(message, "Populacja końcowa");
            }
        }

        private void printAfter(int i)
        {
            if (wyswietl_po.Checked && i == after-1)
            {
                string message = "";
                foreach (var key in population.Keys)
                    message += "\nindex: " + key + " value = [" + String.Join(", ", population[key]) + "]";

                MessageBox.Show(message, "Populacja po " + (i+1) + " iteracjach.");
            }
        }

        private void printBest()
        {
            string message = string.Join(Environment.NewLine, strongestIndividual);
            MessageBox.Show(message, "Optymalne wartości");
        }

        private void populacja_ValueChanged(object sender, EventArgs e)
        {
            this.populationSize = (int)populacja.Value;
            this.rating = new double[populationSize];
        }

        private void zakresOd_ValueChanged(object sender, EventArgs e)
        {
            this.minBound = (int)zakresOd.Value;
        }

        private void zakresDo_ValueChanged(object sender, EventArgs e) => this.maxBound = (int)zakresDo.Value;

        private void wyswietl_po_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void koniec_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tolerancja_ValueChanged(object sender, EventArgs e) => this.tolerance = (int)tolerancja.Value;

        private void iteracje_ValueChanged(object sender, EventArgs e) => this.iterations = (int) iteracje.Value;

        private void populacja_po_x_iteracjach_ValueChanged(object sender, EventArgs e) => this.after = (int)populacja_po_x_iteracjach.Value;

        private void button1_Click(object sender, EventArgs e)
        {
            createPopulation();
            if (indivudual()) return;
            start();
        }
    }
}
