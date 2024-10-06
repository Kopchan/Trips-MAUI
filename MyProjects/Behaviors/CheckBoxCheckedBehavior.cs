using System.Windows.Input;

namespace MyProjects.Behaviors
{
    public class CheckBoxCheckedBehavior : Behavior<CheckBox>
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CheckBoxCheckedBehavior));

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(CheckBoxCheckedBehavior));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        protected override void OnAttachedTo(CheckBox checkBox)
        {
            base.OnAttachedTo(checkBox);
            checkBox.CheckedChanged += OnCheckBoxCheckedChanged;
        }

        protected override void OnDetachingFrom(CheckBox checkBox)
        {
            checkBox.CheckedChanged -= OnCheckBoxCheckedChanged;
            base.OnDetachingFrom(checkBox);
        }

        private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Command != null && Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }
    }

}
