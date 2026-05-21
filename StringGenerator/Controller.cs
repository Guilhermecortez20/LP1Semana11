using System;

namespace StringGenerator
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller()
        {
            model = new Model();
            view = new View();
        }

        public void Run(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int seed))
            {
                view.Show("Nope.");
                return;
            }

            string output = model.Generate(seed);

            view.Show(output);
        }
    }
}
