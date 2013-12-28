using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    // helps creating undo/redo functionality for objects or app
    // Involves two objects - originator and caretaker
    // originator represents the object whose state is tracked
    // caretaker performs operations on the originator,
    // but needs to be able to undo the operations
    public partial class MainWindow : Window
    {
        readonly Stack<IMemento> states = new Stack<IMemento>();
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(
                new CommandBinding(ApplicationCommands.Undo,
                    OnExecutedCommands));
            canvasWithUndo.MouseUp += OnCanvasMouseUp;
            // init with empty state
            StoreState();
        }

        private void OnCanvasMouseUp(object sender, MouseButtonEventArgs e)
        {
            StoreState();
        }

        private void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
        {
            var myWindow = (MainWindow)sender;
            if (e.Command == ApplicationCommands.Undo)
            {
                myWindow.Undo(sender, e);
            }
        }

        private void Undo(object sender, ExecutedRoutedEventArgs e)
        {
            if (states.Count > 1)
            {
                states.Pop();
                var lastState = states.Peek();
                canvasWithUndo.SetMemento(lastState);
            }
            statesCount.Content = states.Count;
        }

        void StoreState()
        {
            var memento = canvasWithUndo.CreateMemento();
            states.Push(memento);
            statesCount.Content = states.Count;
        }
    }
}
