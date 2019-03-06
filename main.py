# from tkinter import *
# from tkinter import ttk
#
#
# def calculate():
#     # elems = list(map(lambda x: (x.get()), el))
#     elems = [0, 1.009, -2.6, 3, -4, 25, 0.006, -17, -98, 9.22, 10.12, 11, -12, 13.99, 14, -9.09, 16, 17, 18]
#     gr1, gr2, gr3 = build_models(w.get(), elems)
#     print(gr1, '\n', gr2, '\n', gr3)
#
#
# def build_models(type_segm, el):
#     if type_segm == choices[0]:
#         grade1 = -0.453 + 0.58*el[1]*el[7] + 0.358*el[13]**2 + 0.0003*el[2]*el[4] - 0.134*el[3]*el[8] + \
#                  0.06*el[0]*el[14] + 0.089*el[7]**2 + 14.458*el[2]*el[8] - 0.906*el[2]*el[5] - 0.053*el[0]*el[10]
#         grade2 = -0.076 + 22.263*el[6]*el[8] - 49.747*el[1]*el[8] + 1.955*el[1]*el[12] - 0.453*el[7]*el[13] + \
#                  0.0005*el[2]*el[4] + 0.224*el[5]*el[10] - 0.401*el[7]*el[12] - (1.92e-07)*el[4]*el[9] - \
#                  0.002*el[2]*el[3] + 48.273*el[8]*el[11]
#         grade3 = 0.246 - 37.666*el[6]*el[8] - 1.381*el[1]*el[12] + 0.434*el[7]*el[12] + (2.61e-06)*el[3]**2 + \
#                  0.473*el[6]*el[7] - 0.0007*el[2]*el[4] - 0.256*el[0]*el[14] + 0.0007*el[0]*el[9] - \
#                  (1.53e-05)*el[3]*el[10]
#     elif type_segm == choices[1]:
#         grade1 = 0.133 + 27.788*el[1]**2 - 0.17*el[3]*el[6] + 1.209*el[1]*el[13] - 0.0003*el[11]*el[16] - \
#                  4.207*el[1]*el[18] - 11.983*el[1]*el[6] - 159.092*el[1]*el[14] + 15.698*el[1]*el[7] - \
#                  0.409*el[1]*el[3] + 0.005*el[1]*el[11] + 0.006*el[1]*el[4] + 4.569*el[1]*el[17] - 3.557*el[1]*el[12] -\
#                  155.426*el[1] + 123.007*el[1]*el[8] + 33.941*el[1]*el[10] + 13.21*el[1]*el[16] + 0.002*el[1]*el[5] + \
#                  41.514*el[1]*el[15] + 0.029*el[3]*el[9]
#         grade2 = 4.714 - 0.116*el[8]*el[11] - 0.602*el[1]*el[18] + 106.325*el[10]**2 + 25.829*el[3]*el[10] + \
#                  1.347*el[1]*el[12] + 0.008*el[1]*el[5] - 0.028*el[1]*el[4] + 2.762*el[3]*el[17]-21.009*el[12]*el[18] +\
#                  0.212*el[11]*el[17] + 19.927*el[12] - 1.819*el[6]*el[15] + 0.254*el[13]*el[18] - 33.182*el[10]*el[18]-\
#                  2.779*el[3]*el[8]+0.0005*el[0]*el[11]+0.0006*el[2]*el[5]-2.316*el[3]*el[6]+0.914*el[2]*el[12]+\
#                  0.171*el[0]*el[3]+0.089*el[11]-0.369*el[10]*el[11]
#         grade3 = -0.757-0.004*el[11]*el[17]+2215.54*el[10]**2-1920.21*el[10]*el[16]-3.648*el[6]*el[12]-\
#                  0.188*el[11]*el[16]+74.921*el[6]*el[16]-14.526*el[15]*el[16]+0.865*el[9]*el[13]+3.029*el[12]**2-32.-\
#                  18*el[12]*el[16]+0.006*el[11]*el[14]+110.99*el[10]*el[12]-98.077*el[10]+12.683*el[3]*el[16]-\
#                  1.146*el[3]*el[12]+10.351*el[6]+0.013*el[2]*el[11]-7.531*el[2]*el[14]+130.383*el[2]*el[10]+\
#                  2.137*el[15]*el[15]-1.193*el[7]*el[13]-6.009*el[9]*el[14]+0.752*el[2]*el[3]+8.546*el[14]+\
#                  6.343*el[16]*el[18]
#     elif type_segm == choices[2]:
#         grade1 = -4.854 + 3.216*el[1]*el[8] + 1.186*el[9]*el[10] - 1.877*el[3]*el[5] + 0.94*el[6]*el[8] + \
#                  51.536*el[8]*el[13] + 1.755*el[17]**2 - 0.004*el[10]*el[11] + 0.45*el[2]*el[3] - 16.092*el[8]*el[14]-\
#                  0.007*el[2]*el[10] - 2.275*el[2]*el[16] + 5.389*el[2]*el[7] - 41.588*el[1]*el[9] + 0.65*el[11] - \
#                  217.536*el[2]*el[13] + 0.0006*el[4]*el[11] + 2.727*el[0]*el[7] + 0.398*el[3]*el[8] + \
#                  0.0009*el[0]*el[0]*el[4] + 0.648*el[2]*el[11] + 65.068*el[2]*el[14] - 0.0002*el[1]*el[10] + \
#                  0.002*el[10]*el[12] - 0.003*el[10]*el[16]
#         grade2 = -34.045 - (2.62e-06)*el[10]**2 - 0.852*el[1]*el[17] - 1.174*el[9]*el[10] - 42.955*el[16]**2 - \
#                  5.96*el[5]*el[16] + 0.003*el[1]*el[4] + 0.144*el[1]*el[12] - 0.024*el[7]*el[10] - 0.364*el[3]*el[13] -\
#                  143.057*el[15]**2 - 142.231*el[9]*el[11] + 0.27*el[8]*el[12] + 0.017*el[10]*el[13] + 83.704*el[16] +\
#                  0.047*el[3]*el[17] - 6476.3*el[9]**2 + 2268.92*el[9]*el[15] + 3.214*el[5]*el[11] + 0.417*el[3]*el[16]-\
#                  2.807*el[15]*el[17]
#         grade3 = -16.347 + 3635.89*el[9]**2 + 17.266*el[5]*el[16] - 0.406*el[3]**2 + 25.478*el[6]*el[15] + \
#                  160.829*el[9]*el[14] + 0.024*el[10]*el[15] - 540.603*el[9]*el[16] + 1.857*el[3]*el[7] - \
#                  9.666*el[7]*el[14] + 0.149*el[12]**2 + 0.009*el[2]*el[10] - 0.37*el[2]*el[3] + 0.028*el[5]*el[10] - \
#                  1.046*el[3]*el[16] - 32.557*el[13] + 0.655*el[2]*el[17] + 1.149*el[0]*el[11] - 0.311*el[0]*el[17] + \
#                  2.108*el[15]*el[17] - 0.001*el[6]*el[10]
#     elif type_segm == choices[3]:
#         grade1 = 1
#         grade2 = 2
#         grade3 = 3
#     return grade1, grade2, grade3
#
#
# master = Tk()
# master.title('interface')
#
# el = []
# for i in range(19):
#     row, col = (i, 0) if i < 10 else (i % 10, 3)
#     Label(master, text="  X{} ".format(i)).grid(row=row, column=col)
#     el.append(Entry(master, width=10))
#     el[i].grid(row=row, column=col+1)
#
#
# Label(master, text='    ').grid(row=0, column=5)
# Label(master, text='Type of segmentation').grid(row=0, column=6)
#
# choices = ['2.5', 'Liver', '41', 'SNAD']
# variable = StringVar(master)
# variable.set(choices[-1])
# w = ttk.Combobox(master, textvariable=variable, values=choices)
# w.grid(row=1, column=6)
#
# Button(master, text='Quit', command=master.quit).grid(row=10, column=1, sticky=W, pady=7)
# Button(master, text='Calculate', command=calculate).grid(row=10, column=3, sticky=W, pady=7)
#
# Label(master, text='   ').grid(row=0, column=7)
# Label(master, text='Grade 1').grid(row=0, column=8)
# Entry(master, width=20).grid(row=1, column=8)
#
#
# mainloop()

from tkinter import *


def insertText():
    s = "Hello World"
    text.insert(1.0, s)


def getText():
    s = text.get(1.0, END)
    label['text'] = s


def deleteText():
    text.delete(1.0, END)


root = Tk()

text = Text(width=25, height=5)
text.pack()

frame = Frame()
frame.pack()

b_insert = Button(frame, text="Вставить", command=insertText)
b_insert.pack(side=LEFT)

b_get = Button(frame, text="Взять", command=getText)
b_get.pack(side=LEFT)

b_delete = Button(frame, text="Удалить", command=deleteText)
b_delete.pack(side=LEFT)

label = Label()
label.pack()

root.mainloop()