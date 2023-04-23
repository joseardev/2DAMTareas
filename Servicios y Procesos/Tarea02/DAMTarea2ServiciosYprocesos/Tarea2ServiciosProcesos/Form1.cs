using Tarea02.Clases;

namespace Tarea2ServiciosProcesos
{
    public partial class Form1 : Form
    {
        //Inicializamos los 4 coches
        Coche coche01 = new Coche(10, "B");
        Coche coche02 = new Coche(10, "B");
        Coche coche03 = new Coche(10, "B");
        Coche coche04 = new Coche(10, "B");

        //Clase Ramdon necesaria para usar las funciones
        Random random = new Random();

        //Delegados        
        delegate void delegado();

        //Variables clase
        bool pararCarrera = false;
        string dificultad;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setupFromLoad();
        }
        private void setupFromLoad()
        {
            //Inicializamos Facil como nivel incial
            rbFacil.Checked = true;
            dificultad = "facil";
            CheckForIllegalCrossThreadCalls = false;
            //enviamos los picturebox al fondo 
            pbCarretera01.SendToBack();
            pbCarretera02.SendToBack();
            pbCarretera03.SendToBack();
            pbCarretera04.SendToBack();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            //Creamos hilo
            Thread carrera = new Thread(IniciarCarrera);
            //Iniciamos hilo
            carrera.Start();
        }
        
        private void IniciarCarrera()
        {
            pararCarrera = false;
            delegado IniciarCarrera = new delegado(iniciarCarrera);
            //Iniciamos carrera
            IniciarCarrera.Invoke();
        }
        private void iniciarCarrera()
        {
            setEstadoIncial();
            acelerar();
        }
        private void setEstadoIncial()
        {
            //estado coche
            coche01.setEstado("B");
            coche02.setEstado("B");
            coche03.setEstado("B");
            coche04.setEstado("B");
            //estado coche textBox
            tbCoche01.Text = "BIEN";
            tbCoche02.Text = "BIEN";
            tbCoche03.Text = "BIEN";
            tbCoche04.Text = "BIEN";
            //color estado B Verde
            tbCoche01.BackColor = System.Drawing.Color.Green;
            tbCoche02.BackColor = System.Drawing.Color.Green;
            tbCoche03.BackColor = System.Drawing.Color.Green;
            tbCoche04.BackColor = System.Drawing.Color.Green;
            //Posicionamos Coches en la linea de salida
            setLineaSalida(pbParticipante01, 1);
            setLineaSalida(pbParticipante02, 2);
            setLineaSalida(pbParticipante03, 3);
            setLineaSalida(pbParticipante04, 4);                     
        }

        //Iniciamos carrera
        private void acelerar()
        {
            for (int i = 0; i < this.Width; i++)
            {
                estadoCochesCarrera();
                if (creaPodium())
                {
                    break;
                }
                Thread.Sleep(30);
                if (pararCarrera)
                {
                    pararCarrera = false;
                    break;
                }
                if (coche01.estado == "R" && coche02.estado == "R" && coche03.estado == "R" && coche04.estado == "R")
                {
                    break;
                }
            }
        }
        

        //comprueba estado actual de los coches       
        private void estadoCochesCarrera()
        {

            if (coche01.getEstado() == "B")
            {
                pbParticipante01.Left += random.Next(coche01.getVelocidad());
                if (estadoTiempo(pbParticipante01))
                {
                    //Coche estropeado
                    coche01.setEstado("R");
                    tbCoche01.Text = "Estropeado";
                    tbCoche01.BackColor = System.Drawing.Color.Red;
                }
            }

            if (coche02.getEstado() == "B")
            {
                pbParticipante02.Left += random.Next(coche02.getVelocidad());
                if (estadoTiempo(pbParticipante02))
                {
                    //Coche estropeado
                    coche02.setEstado("R");
                    tbCoche02.Text = "Estropeado";
                    tbCoche02.BackColor = System.Drawing.Color.Red;
                }
            }
            if (coche03.getEstado() == "B")
            {
                pbParticipante03.Left += random.Next(coche03.getVelocidad());
                if (estadoTiempo(pbParticipante03))
                {
                    //Coche estropeado
                    coche03.setEstado("R");
                    tbCoche03.Text = "Estropeado";
                    tbCoche03.BackColor = System.Drawing.Color.Red;
                }
            }

            if (coche04.getEstado() == "B")
            {
                pbParticipante04.Left += random.Next(coche04.getVelocidad());
                if (estadoTiempo(pbParticipante04))
                {
                    //Coche estropeado
                    coche04.setEstado("R");
                    tbCoche04.Text = "Estropeado";
                    tbCoche04.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        //Genera podium cuando tenemos ganador
        //devuelve True SI tenemos gandor
        //devuelve False NO tenemos gandor
        private bool creaPodium()
        {
            bool tenemosGanador = false;
            //Comprobamos si participante01 es ganador
            if (pbParticipante01.Left > this.Width)
            {
                msgBoxGanador("Linea01");
                setPodiumView(pbParticipante01, 1);
                //comprobamos 2 y 3 posicion
                if (pbParticipante02.Left > pbParticipante03.Left && pbParticipante02.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante02, 2);
                    if (pbParticipante03.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                ///
                if (pbParticipante03.Left > pbParticipante02.Left && pbParticipante03.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante03, 2);
                    if (pbParticipante02.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                //
                if (pbParticipante04.Left > pbParticipante02.Left && pbParticipante04.Left > pbParticipante03.Left)
                {
                    setPodiumView(pbParticipante04, 2);
                    if (pbParticipante02.Left > pbParticipante03.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                }                
                tenemosGanador = true;
            }
            //Comprobamos si participante02 es ganador
            if (pbParticipante02.Left > this.Width)
            {
                msgBoxGanador("Linea02");
                setPodiumView(pbParticipante02, 1);
                //comprobamos 2 y 3 posicion
                if (pbParticipante01.Left > pbParticipante03.Left && pbParticipante01.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante01, 2);
                    if (pbParticipante03.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                ///
                if (pbParticipante03.Left > pbParticipante01.Left && pbParticipante03.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante03, 2);
                    if (pbParticipante01.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante01, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                //
                if (pbParticipante04.Left > pbParticipante01.Left && pbParticipante04.Left > pbParticipante03.Left)
                {
                    setPodiumView(pbParticipante04, 2);
                    if (pbParticipante01.Left > pbParticipante03.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                }
                tenemosGanador = true;
            }
            //Comprobamos si participante03 es ganador
            if (pbParticipante03.Left > this.Width)
            {
                msgBoxGanador("Linea03");
                setPodiumView(pbParticipante03, 1);
                //comprobamos 2 y 3 posicion
                if (pbParticipante01.Left > pbParticipante02.Left && pbParticipante01.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante01, 2);
                    if (pbParticipante02.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                ///
                if (pbParticipante02.Left > pbParticipante01.Left && pbParticipante02.Left > pbParticipante04.Left)
                {
                    setPodiumView(pbParticipante02, 2);
                    if (pbParticipante01.Left > pbParticipante04.Left)
                    {
                        setPodiumView(pbParticipante01, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante04, 3);
                    }
                }
                //
                if (pbParticipante04.Left > pbParticipante02.Left && pbParticipante04.Left > pbParticipante01.Left)
                {
                    setPodiumView(pbParticipante04, 2);
                    if (pbParticipante02.Left > pbParticipante03.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante01, 3);
                    }
                }
                tenemosGanador = true;
            }
            //Comprobamos si participante04 es ganador
            if (pbParticipante04.Left > this.Width)
            {
                msgBoxGanador("Linea04");
                setPodiumView(pbParticipante04, 1);

                //comprobamos 2 y 3 posicion
                if (pbParticipante01.Left > pbParticipante02.Left && pbParticipante01.Left > pbParticipante03.Left)
                {
                    setPodiumView(pbParticipante01, 2);
                    if (pbParticipante02.Left > pbParticipante03.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                }                
                if (pbParticipante02.Left > pbParticipante01.Left && pbParticipante02.Left > pbParticipante03.Left)
                {
                    setPodiumView(pbParticipante02, 2);
                    if (pbParticipante01.Left > pbParticipante03.Left)
                    {
                        setPodiumView(pbParticipante01, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante03, 3);
                    }
                }                
                if (pbParticipante03.Left > pbParticipante02.Left && pbParticipante03.Left > pbParticipante01.Left)
                {
                    setPodiumView(pbParticipante03, 2);
                    if (pbParticipante02.Left > pbParticipante01.Left)
                    {
                        setPodiumView(pbParticipante02, 3);
                    }
                    else
                    {
                        setPodiumView(pbParticipante01, 3);
                    }
                }
                tenemosGanador = true;
            }
            return tenemosGanador;
        }
        //Compruba si el coche se estropea
        // return True coche estropeado
        private Boolean estadoTiempo(PictureBox pictureBox)
        {
            bool resultadoAcidente;            
            return resultadoAcidente = (random.Next(getMaxRamdon()) == 2) ? true : false;            
        }

        //Posibilidad de accidente
        //Devuelve según el tiempo actual la posibilidad de accidente
        private int getMaxRamdon()
        {
            int maxRamdon = 10;
            if (dificultad == "facil")
            {
                maxRamdon = 300;
            }
            else if (dificultad == "media")
            {
                maxRamdon = 150;
            }
            else if (dificultad == "dificil")
            {
                maxRamdon = 100;
            }

            return maxRamdon;
        }

        //Genera podium
        //param PictureBox => Picturebox a posicionar 
        //param posicionPodio => posición que se muestra en el podium
        private void setPodiumView(PictureBox pictureBox, int posicionPodio)
        {
            switch (posicionPodio)
            {
                case 1:
                    pictureBox.Left = 210;
                    pictureBox.Top = 390;
                    break;
                case 2:
                    pictureBox.Left = 70;
                    pictureBox.Top = 440;
                    break;
                case 3:
                    pictureBox.Left = 360;
                    pictureBox.Top = 445;
                    break;
            }
            pictureBox.BringToFront();


        }
        //Muestra mensaje ganador 
        //param nombreGanador => Nombre Ganador carrera
        private void msgBoxGanador(string nombreGanador)
        {
            string message = nombreGanador + " gano la carrera";
            string caption = "FINAL";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
        }
        //Carga linea de salida
        //param pictureBox     => Picturebox a posicionar
        //param posicionSalida => posicion que queremos posicionar el picturebox
        private void setLineaSalida(PictureBox pictureBox, int posicionSalida)
        {

            switch (posicionSalida)
            {
                case 1:
                    pictureBox.Left = 10;
                    pictureBox.Top = 10;
                    break;
                case 2:
                    pictureBox.Left = 10;
                    pictureBox.Top = 76;
                    break;
                case 3:
                    pictureBox.Left = 10;
                    pictureBox.Top = 140;
                    break;
                case 4:
                    pictureBox.Left = 10;
                    pictureBox.Top = 190;
                    break;
                default:

                    break;
            }
            pictureBox.BringToFront();
        }        
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            setEstadoIncial();
            pararCarrera = true;

        }
        private void btAcelerar_Click(object sender, EventArgs e)
        {
            acelerarCoche();
        }

        //Acelera linea selecionada en cbLinea
        private void acelerarCoche()
        {
            var lineaSelecionada = cbLinea.Text;
            if (lineaSelecionada == "Coche01")
            {
                pbParticipante01.Left += 50;
            }
            else if (lineaSelecionada == "Coche02")
            {
                pbParticipante02.Left += 50;
            }
            else if (lineaSelecionada == "Coche03")
            {
                pbParticipante03.Left += 50;
            }
            else if (lineaSelecionada == "Coche04")
            {
                pbParticipante04.Left += 50;
            }
        }
        //Radion Button NIVELES
        private void rbFacil_CheckedChanged(object sender, EventArgs e)
        {
            dificultad = "facil";
            tbTiempo.Text = "Buen Tiempo";
            tbTiempo.BackColor = System.Drawing.Color.LightYellow;
        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            dificultad = "media";
            tbTiempo.Text = "Llueve";
            tbTiempo.BackColor = System.Drawing.Color.CadetBlue;
        }

        private void rbDificil_CheckedChanged(object sender, EventArgs e)
        {
            dificultad = "dificil";
            tbTiempo.Text = "Alerta Naranja";
            tbTiempo.BackColor = System.Drawing.Color.Orange;
        }
    }

}
