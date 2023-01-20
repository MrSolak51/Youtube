from tkinter import *
import tkinter.font as tkFont

import webbrowser

WIDTH = 500
HEIGHT = 500
CANVA_WIDTH = 500
CANVA_HEIGHT = 300
red_point = CANVA_WIDTH/2
blue_point = 0
game_over = False

window = Tk()
window.title("HALAT ÇEKME")
window.geometry(str(WIDTH) + "x" + str(HEIGHT))

canvas = Canvas(window, width=CANVA_WIDTH, height=CANVA_HEIGHT, bg="white")
canvas.pack()
canvas.create_rectangle(0, CANVA_HEIGHT/2-25, CANVA_WIDTH/2, CANVA_HEIGHT/2+25, fill="red")
canvas.create_rectangle(CANVA_WIDTH/2, CANVA_HEIGHT/2-25, CANVA_WIDTH, CANVA_HEIGHT/2+25, fill="blue")


def playstore_link():
    webbrowser.open("https://play.google.com/store/apps/dev?id=8068675830237888072")


def github_link():
    webbrowser.open("https://github.com/MrSolak51?tab=repositories")


def red_pull(e):
    global blue_point, red_point, game_over
    if blue_point == 250:
        canvas.create_text(CANVA_WIDTH/2,
                           CANVA_HEIGHT/2,
                           font=("Times", "24", "bold italic"),
                           text="Kırmızı Kazandı",
                           fill="red")
        game_over = True
    elif game_over is False:
        red_point -= 10
        blue_point += 10
        canvas.create_rectangle(CANVA_WIDTH/2-blue_point,
                                CANVA_HEIGHT / 2 - 25,
                                CANVA_WIDTH,
                                CANVA_HEIGHT / 2 + 25,
                                fill="blue")


def blue_pull(e):
    global blue_point, red_point, game_over
    if red_point == 500:
        canvas.create_text(CANVA_WIDTH/2,
                           CANVA_HEIGHT/2,
                           font=("Times", "24", "bold italic"),
                           text="Mavi Kazandı",
                           fill="blue")
        game_over = True
    elif game_over is False:
        red_point += 10
        blue_point -= 10
        canvas.create_rectangle(0,
                                CANVA_HEIGHT / 2 - 25,
                                red_point,
                                CANVA_HEIGHT / 2 + 25,
                                fill="red")


window.bind("a", red_pull)
window.bind("l", blue_pull)


def restart():
    global red_point, blue_point, game_over
    red_point = CANVA_WIDTH / 2
    blue_point = 0
    game_over = False
    canvas.create_rectangle(0, CANVA_HEIGHT / 2 - 25, CANVA_WIDTH / 2, CANVA_HEIGHT / 2 + 25, fill="red")
    canvas.create_rectangle(CANVA_WIDTH / 2, CANVA_HEIGHT / 2 - 25, CANVA_WIDTH, CANVA_HEIGHT / 2 + 25, fill="blue")


restart_button = Button(window, text="Yeniden Oyna", command=restart)
restart_button.pack()

github_link_button = Button(window, text="Visit my github", command=github_link, border=0,
                            fg="blue")
f = tkFont.Font(github_link_button, github_link_button.cget("font"))
f.configure(underline=True)
github_link_button.pack()
github_link_button.configure(font=f)


playstore_link_button = Button(window, text="Visit my playstore", command=playstore_link, border=0,
                               font=f,
                               fg="blue")
f = tkFont.Font(playstore_link_button, playstore_link_button.cget("font"))
f.configure(underline=True)
playstore_link_button.pack()
playstore_link_button.configure(font=f)

window.mainloop()
