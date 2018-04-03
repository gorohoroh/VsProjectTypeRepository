import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'IronPython_WPF_Application.xaml')
    

if __name__ == '__main__':
    Application().Run(MyWindow())
