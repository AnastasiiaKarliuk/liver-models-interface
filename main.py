from tkinter import *
from tkinter import ttk


def calculate():
    print(list(map(lambda x: float(x.get()), el)))
    gr1, gr2, gr3 = build_models(w.get())
    print(gr1)


def build_models(type_segm):
    if type_segm == choices[0]:
        grade1 = 1
        grade2 = 2
        grade3 = 3
    elif type_segm == choices[1]:
        grade1 = 1
        grade2 = 2
        grade3 = 3
    elif type_segm == choices[2]:
        grade1 = 1
        grade2 = 2
        grade3 = 3
    elif type_segm == choices[3]:
        grade1 = 1
        grade2 = 2
        grade3 = 3
    return grade1, grade2, grade3


master = Tk()
# master.geometry("500x100") #You want the size of the app to be 500x500
master.title('interface')

el = []
for i in range(2):
    row, col = (i, 0) if i < 9 else (i % 9, 3)
    Label(master, text="  X{} ".format(i)).grid(row=row, column=col)
    el.append(Entry(master, width=10))
    el[i].grid(row=row, column=col+1)

Label(master, text='    ').grid(row=0, column=5)
Label(master, text='Type of segmentation').grid(row=0, column=6)
choices = ['2.5', 'Liver', '41', 'SNAD']
variable = StringVar(master)
variable.set(choices[-1])
w = ttk.Combobox(master, textvariable=variable, values=choices)
w.grid(row=1, column=6)

Button(master, text='Quit', command=master.quit).grid(row=10, column=1, sticky=W, pady=7)
Button(master, text='Calculate', command=calculate).grid(row=10, column=3, sticky=W, pady=7)


# def show_text():
#     label_text.set('Heh, heh, heh, you said, "' + gr1 + '"')

Label(master, text='Grade 1').grid(row=0, column=7)

mainloop()


