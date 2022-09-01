using KsiazkaPrzepisyKokot.BuisnessLayer.Implementacje;
using KsiazkaPrzepisyKokot.Controllers;
using KsiazkaPrzepisyKokot.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testy.controller
{
    class TestControllers
    {
        [Test]
        public void ReturnNullObjectByLoginAndPasswd()
        {
            // Arrange
            var LogBL = new LogBL_();
            var controller = new LogController_(LogBL);
            var nonExistentLogin = "noExist";
            var nonExistentPasswd = "noExist";

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => controller.Login(nonExistentLogin, nonExistentPasswd));
            
        }
    [Test]
    public void ReturnFullPrzepisAfterCreate()
    {

            // Arrange
            int id_przepisu = 10, id_skladnika1 = 10;
            var PrzepisyBL = new PrzepisyBL_();
            var WszystkieSkladnikiBL = new WszystkieSkladnikiBL_();
            var SkladnikiPrzepisuBL = new SkladnikiPrzepisuBL_();
            var KompletnyPRzepisBL_ = new KompletnyPrzepisBL_(PrzepisyBL, SkladnikiPrzepisuBL);

            var controllerPrzepisy = new PrzepisyController_(PrzepisyBL);
            var controllerSkladnikiPrzepisu = new SkladnikPrzepisuController_(SkladnikiPrzepisuBL);
            var controllerWszystkieSkladniki = new WszystkieSkladnikiController_(WszystkieSkladnikiBL);
            var controllerKompletnyPrzepis = new KompletnyPrzepisController_(KompletnyPRzepisBL_);

            Przepisy przepisTestowy = new Sniadania
            {
                czas = TimeSpan.FromHours(2),
                data = DateTime.Now,
                nazwaDania = "testowe danie",
                liczbaPorcji = 4,
                Przepis = "dodać testowe skladniki, wymieszać i test zaliczony",
                Obraz = new byte[] { 0, 16, 104, 213 },//binarnie
                idPrzepisu=id_przepisu,

                na_slodko = true,
                na_slono=true,
                bez_miesa=true,
                fit=true,
                z_jajkiem=true
            };

            WszystkieSkladniki skladnik1 = new WszystkieSkladniki
            {
                gram_kcal = 2,
                skladnik = "Jabłko",
                lyzeczka_kcal = 2,
                szklanka_kcal = 2,
                lyzka_kcal = 2,
                idWszystkieSkladniki=id_skladnika1
                
            };

            //dodanie sniadania
            var dodaneSniadanie=controllerPrzepisy.Dodaj(przepisTestowy);

            //dodanie skladnika do lity wszystkich skladnikow
            var dodanyWszystkiSkladnik=controllerWszystkieSkladniki.Post(skladnik1);

            //polaczenie skladnikow z przepisem
            Assert.Throws<ArgumentException>(() => controllerSkladnikiPrzepisu.Post(przepisTestowy.idPrzepisu, skladnik1.idWszystkieSkladniki, KsiazkaPrzepisyKokot.Interfaces.Miara.Szklanka, 3));
            Assert.AreEqual(dodaneSniadanie, przepisTestowy);
            Assert.AreEqual(dodanyWszystkiSkladnik, skladnik1);

        }
}
}
