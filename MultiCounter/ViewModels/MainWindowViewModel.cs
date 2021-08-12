using MultiCounter.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace MultiCounter.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        //==========モデルデータ==========
        /// <summary>
        /// カウンタモデル
        /// </summary>
        CounterModel count = new CounterModel();

        //==========バインディングデータ==========
        /// <summary>
        /// バインディングデータ：タイトル
        /// </summary>
        private string _title = "Multi Counter";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// バインディングデータ：選択中のカウンタNo.
        /// </summary>
        private int _selected_counter = CounterModel.DefCounter1;
        public int SelectedCounter
        {
            get { return _selected_counter; }
            set { SetProperty(ref _selected_counter, value); }
        }

        /// <summary>
        /// バインディングデータ：カウンタ(No.1)
        /// </summary>
        private string _counter1 = "0";
        public string Counter1
        {
            get { return _counter1; }
            set { SetProperty(ref _counter1, value); }
        }

        /// <summary>
        /// バインディングデータ：カウンタ(No.2)
        /// </summary>
        private string _counter2 = "0";
        public string Counter2
        {
            get { return _counter2; }
            set { SetProperty(ref _counter2, value); }
        }

        /// <summary>
        /// バインディングデータ：カウンタ(No.3)
        /// </summary>
        private string _counter3 = "0";
        public string Counter3
        {
            get { return _counter3; }
            set { SetProperty(ref _counter3, value); }
        }

        /// <summary>
        /// バインディングデータ：カウンタ(No.4)
        /// </summary>
        private string _counter4 = "0";
        public string Counter4
        {
            get { return _counter4; }
            set { SetProperty(ref _counter4, value); }
        }

        /// <summary>
        /// バインディングデータ：カウンタ(No.5)
        /// </summary>
        private string _counter5 = "0";
        public string Counter5
        {
            get { return _counter5; }
            set { SetProperty(ref _counter5, value); }
        }

        //==========バインディングコマンド==========
        /// <summary>
        /// バインディングコマンド：カウントアップ(選択中)
        /// </summary>
        private DelegateCommand _command_countupselected;
        public DelegateCommand CommandCountUpSelected =>
            _command_countupselected ?? (_command_countupselected = new DelegateCommand(ExecuteCommandCountUpSelected));

        /// <summary>
        /// バインディングコマンド：カウントダウン(選択中)
        /// </summary>
        private DelegateCommand _command_countdownselected;
        public DelegateCommand CommandCountDownSelected =>
            _command_countdownselected ?? (_command_countdownselected = new DelegateCommand(ExecuteCommandCountDownSelected));

        /// <summary>
        /// バインディングコマンド：カウントクリア(選択中)
        /// </summary>
        private DelegateCommand _command_countclearselected;
        public DelegateCommand CommandCountClearSelected =>
            _command_countclearselected ?? (_command_countclearselected = new DelegateCommand(ExecuteCommandCountClearSelected));

        /// <summary>
        /// バインディングコマンド：カウントアップ(No.1)
        /// </summary>
        private DelegateCommand _command_countup1;
        public DelegateCommand CommandCountUp1 =>
            _command_countup1 ?? (_command_countup1 = new DelegateCommand(ExecuteCommandCountUp1));

        /// <summary>
        /// バインディングコマンド：カウントダウン(No.1)
        /// </summary>
        private DelegateCommand _command_countdown1;
        public DelegateCommand CommandCountDown1 =>
            _command_countdown1 ?? (_command_countdown1 = new DelegateCommand(ExecuteCommandCountDown1));

        /// <summary>
        /// バインディングコマンド：カウントクリア(No.1)
        /// </summary>
        private DelegateCommand _command_countclear1;
        public DelegateCommand CommandCountClear1 =>
            _command_countclear1 ?? (_command_countclear1 = new DelegateCommand(ExecuteCommandCountClear1));

        /// <summary>
        /// バインディングコマンド：カウントアップ(No.2)
        /// </summary>
        private DelegateCommand _command_countup2;
        public DelegateCommand CommandCountUp2 =>
            _command_countup2 ?? (_command_countup2 = new DelegateCommand(ExecuteCommandCountUp2));

        /// <summary>
        /// バインディングコマンド：カウントダウン(No.2)
        /// </summary>
        private DelegateCommand _command_countdown2;
        public DelegateCommand CommandCountDown2 =>
            _command_countdown2 ?? (_command_countdown2 = new DelegateCommand(ExecuteCommandCountDown2));

        /// <summary>
        /// バインディングコマンド：カウントクリア(No.2)
        /// </summary>
        private DelegateCommand _command_countclear2;
        public DelegateCommand CommandCountClear2 =>
            _command_countclear2 ?? (_command_countclear2 = new DelegateCommand(ExecuteCommandCountClear2));

        /// <summary>
        /// バインディングコマンド：カウントアップ(No.3)
        /// </summary>
        private DelegateCommand _command_countup3;
        public DelegateCommand CommandCountUp3 =>
            _command_countup3 ?? (_command_countup3 = new DelegateCommand(ExecuteCommandCountUp3));

        /// <summary>
        /// バインディングコマンド：カウントダウン(No.3)
        /// </summary>
        private DelegateCommand _command_countdown3;
        public DelegateCommand CommandCountDown3 =>
            _command_countdown3 ?? (_command_countdown3 = new DelegateCommand(ExecuteCommandCountDown3));

        /// <summary>
        /// バインディングコマンド：カウントクリア(No.3)
        /// </summary>
        private DelegateCommand _command_countclear3;
        public DelegateCommand CommandCountClear3 =>
            _command_countclear3 ?? (_command_countclear3 = new DelegateCommand(ExecuteCommandCountClear3));

        /// <summary>
        /// バインディングコマンド：カウントアップ(No.4)
        /// </summary>
        private DelegateCommand _command_countup4;
        public DelegateCommand CommandCountUp4 =>
            _command_countup4 ?? (_command_countup4 = new DelegateCommand(ExecuteCommandCountUp4));

        /// <summary>
        /// バインディングコマンド：カウントダウン(No.4)
        /// </summary>
        private DelegateCommand _command_countdown4;
        public DelegateCommand CommandCountDown4 =>
            _command_countdown4 ?? (_command_countdown4 = new DelegateCommand(ExecuteCommandCountDown4));

        /// <summary>
        /// バインディングコマンド：カウントクリア(No.4)
        /// </summary>
        private DelegateCommand _command_countclear4;
        public DelegateCommand CommandCountClear4 =>
            _command_countclear4 ?? (_command_countclear4 = new DelegateCommand(ExecuteCommandCountClear4));

        /// <summary>
        /// バインディングコマンド：カウントアップ(No.5)
        /// </summary>
        private DelegateCommand _command_countup5;
        public DelegateCommand CommandCountUp5 =>
            _command_countup5 ?? (_command_countup5 = new DelegateCommand(ExecuteCommandCountUp5));

        /// <summary>
        /// バインディングコマンド：カウントダウン(No.5)
        /// </summary>
        private DelegateCommand _command_countdown5;
        public DelegateCommand CommandCountDown5 =>
            _command_countdown5 ?? (_command_countdown5 = new DelegateCommand(ExecuteCommandCountDown5));

        /// <summary>
        /// バインディングコマンド：カウントクリア(No.5)
        /// </summary>
        private DelegateCommand _command_countclear5;
        public DelegateCommand CommandCountClear5 =>
            _command_countclear5 ?? (_command_countclear5 = new DelegateCommand(ExecuteCommandCountClear5));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(No.1)
        /// </summary>
        private DelegateCommand _command_selectcounter1;
        public DelegateCommand CommandSelectCounter1 =>
            _command_selectcounter1 ?? (_command_selectcounter1 = new DelegateCommand(ExecuteCommandSelectCounter1));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(No.2)
        /// </summary>
        private DelegateCommand _command_selectcounter2;
        public DelegateCommand CommandSelectCounter2 =>
            _command_selectcounter2 ?? (_command_selectcounter2 = new DelegateCommand(ExecuteCommandSelectCounter2));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(No.3)
        /// </summary>
        private DelegateCommand _command_selectcounter3;
        public DelegateCommand CommandSelectCounter3 =>
            _command_selectcounter3 ?? (_command_selectcounter3 = new DelegateCommand(ExecuteCommandSelectCounter3));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(No.4)
        /// </summary>
        private DelegateCommand _command_selectcounter4;
        public DelegateCommand CommandSelectCounter4 =>
            _command_selectcounter4 ?? (_command_selectcounter4 = new DelegateCommand(ExecuteCommandSelectCounter4));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(No.5)
        /// </summary>
        private DelegateCommand _command_selectcounter5;
        public DelegateCommand CommandSelectCounter5 =>
            _command_selectcounter5 ?? (_command_selectcounter5 = new DelegateCommand(ExecuteCommandSelectCounter5));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(右)
        /// </summary>
        private DelegateCommand _command_selectcounterright;
        public DelegateCommand CommandSelectCounterRight =>
            _command_selectcounterright ?? (_command_selectcounterright = new DelegateCommand(ExecuteCommandSelectCounterRight));

        /// <summary>
        /// バインディングコマンド：カウンタ選択(左)
        /// </summary>
        private DelegateCommand _command_selectcounterleft;
        public DelegateCommand CommandSelectCounterLeft =>
            _command_selectcounterleft ?? (_command_selectcounterleft = new DelegateCommand(ExecuteCommandSelectCounterLeft));

        //==========コンストラクター==========
        /// <summary>
        /// コンストラクター
        /// </summary>
        public MainWindowViewModel()
        {
            ;
        }

        //==========メソッド==========
        /// <summary>
        /// カウントアップ(選択中)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUpSelected()
        {
            if (SelectedCounter == CounterModel.DefCounter1)
            {
                Counter1 = count.IncrementSelectedCounter(CounterModel.DefCounter1);
            }
            else if (SelectedCounter == CounterModel.DefCounter2)
            {
                Counter2 = count.IncrementSelectedCounter(CounterModel.DefCounter2);
            }
            else if (SelectedCounter == CounterModel.DefCounter3)
            {
                Counter3 = count.IncrementSelectedCounter(CounterModel.DefCounter3);
            }
            else if (SelectedCounter == CounterModel.DefCounter4)
            {
                Counter4 = count.IncrementSelectedCounter(CounterModel.DefCounter4);
            }
            else if (SelectedCounter == CounterModel.DefCounter5)
            {
                Counter5 = count.IncrementSelectedCounter(CounterModel.DefCounter5);
            }
            else
            {
                ;
            }
        }

        /// <summary>
        /// カウントダウン(選択中)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDownSelected()
        {
            if (SelectedCounter == CounterModel.DefCounter1)
            {
                Counter1 = count.DecrementSelectedCounter(CounterModel.DefCounter1);
            }
            else if (SelectedCounter == CounterModel.DefCounter2)
            {
                Counter2 = count.DecrementSelectedCounter(CounterModel.DefCounter2);
            }
            else if (SelectedCounter == CounterModel.DefCounter3)
            {
                Counter3 = count.DecrementSelectedCounter(CounterModel.DefCounter3);
            }
            else if (SelectedCounter == CounterModel.DefCounter4)
            {
                Counter4 = count.DecrementSelectedCounter(CounterModel.DefCounter4);
            }
            else if (SelectedCounter == CounterModel.DefCounter5)
            {
                Counter5 = count.DecrementSelectedCounter(CounterModel.DefCounter5);
            }
            else
            {
                ;
            }
        }

        /// <summary>
        /// カウントクリア(選択中)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClearSelected()
        {
            if (SelectedCounter == CounterModel.DefCounter1)
            {
                Counter1 = count.ClearSelectedCounter(CounterModel.DefCounter1);
            }
            else if (SelectedCounter == CounterModel.DefCounter2)
            {
                Counter2 = count.ClearSelectedCounter(CounterModel.DefCounter2);
            }
            else if (SelectedCounter == CounterModel.DefCounter3)
            {
                Counter3 = count.ClearSelectedCounter(CounterModel.DefCounter3);
            }
            else if (SelectedCounter == CounterModel.DefCounter4)
            {
                Counter4 = count.ClearSelectedCounter(CounterModel.DefCounter4);
            }
            else if (SelectedCounter == CounterModel.DefCounter5)
            {
                Counter5 = count.ClearSelectedCounter(CounterModel.DefCounter5);
            }
            else
            {
                ;
            }
        }

        /// <summary>
        /// カウントアップ(No.1)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUp1()
        {
            Counter1 = count.IncrementSelectedCounter(CounterModel.DefCounter1);
        }

        /// <summary>
        /// カウントダウン(No.1)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDown1()
        {
            Counter1 = count.DecrementSelectedCounter(CounterModel.DefCounter1);
        }

        /// <summary>
        /// カウントクリア(No.1)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClear1()
        {
            Counter1 = count.ClearSelectedCounter(CounterModel.DefCounter1);
        }

        /// <summary>
        /// カウントアップ(No.2)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUp2()
        {
            Counter2 = count.IncrementSelectedCounter(CounterModel.DefCounter2);
        }

        /// <summary>
        /// カウントダウン(No.2)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDown2()
        {
            Counter2 = count.DecrementSelectedCounter(CounterModel.DefCounter2);
        }

        /// <summary>
        /// カウントクリア(No.2)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClear2()
        {
            Counter2 = count.ClearSelectedCounter(CounterModel.DefCounter2);
        }

        /// <summary>
        /// カウントアップ(No.3)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUp3()
        {
            Counter3 = count.IncrementSelectedCounter(CounterModel.DefCounter3);
        }

        /// <summary>
        /// カウントダウン(No.3)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDown3()
        {
            Counter3 = count.DecrementSelectedCounter(CounterModel.DefCounter3);
        }

        /// <summary>
        /// カウントクリア(No.3)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClear3()
        {
            Counter3 = count.ClearSelectedCounter(CounterModel.DefCounter3);
        }

        /// <summary>
        /// カウントアップ(No.4)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUp4()
        {
            Counter4 = count.IncrementSelectedCounter(CounterModel.DefCounter4);
        }

        /// <summary>
        /// カウントダウン(No.4)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDown4()
        {
            Counter4 = count.DecrementSelectedCounter(CounterModel.DefCounter4);
        }

        /// <summary>
        /// カウントクリア(No.4)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClear4()
        {
            Counter4 = count.ClearSelectedCounter(CounterModel.DefCounter4);
        }

        /// <summary>
        /// カウントアップ(No.5)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountUp5()
        {
            Counter5 = count.IncrementSelectedCounter(CounterModel.DefCounter5);
        }

        /// <summary>
        /// カウントダウン(No.5)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountDown5()
        {
            Counter5 = count.DecrementSelectedCounter(CounterModel.DefCounter5);
        }

        /// <summary>
        /// カウントクリア(No.5)コマンド実行処理
        /// </summary>
        private void ExecuteCommandCountClear5()
        {
            Counter5 = count.ClearSelectedCounter(CounterModel.DefCounter5);
        }

        /// <summary>
        /// カウンタ選択(No.1)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounter1()
        {
            SelectedCounter = CounterModel.DefCounter1;
        }

        /// <summary>
        /// カウンタ選択(No.2)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounter2()
        {
            SelectedCounter = CounterModel.DefCounter2;
        }

        /// <summary>
        /// カウンタ選択(No.3)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounter3()
        {
            SelectedCounter = CounterModel.DefCounter3;
        }

        /// <summary>
        /// カウンタ選択(No.4)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounter4()
        {
            SelectedCounter = CounterModel.DefCounter4;
        }

        /// <summary>
        /// カウンタ選択(No.5)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounter5()
        {
            SelectedCounter = CounterModel.DefCounter5;
        }

        /// <summary>
        /// カウンタ選択(右)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounterRight()
        {
            if (SelectedCounter < CounterModel.DefCounter5)
            {
                SelectedCounter++;
            }
            else
            {
                SelectedCounter = CounterModel.DefCounter1;
            }
        }

        /// <summary>
        /// カウンタ選択(左)コマンド実行処理
        /// </summary>
        private void ExecuteCommandSelectCounterLeft()
        {
            if (CounterModel.DefCounter1 < SelectedCounter)
            {
                SelectedCounter--;
            }
            else
            {
                SelectedCounter = CounterModel.DefCounter5;
            }
        }
    }
}
