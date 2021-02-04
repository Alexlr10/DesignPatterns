using System;


namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder()
        {
            this.celular = new Celular("Iphone");
        }

        public void BuildBateria()
        {
            this.celular = new Celular("Iphone");
        }

        public void BuildCamera()
        {
            this.celular.camera = "12 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "IOS";
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
