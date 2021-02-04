using System;


namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
       public AndroidBuilder()
        {
            this.celular = new Celular("Android"); 
        }
        public void BuildBateria()
        {
            this.celular.bateria = "MAH1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "Android 10";
        }

        public void BuildTela()
        {
            this.celular.tela = "6";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }
}
