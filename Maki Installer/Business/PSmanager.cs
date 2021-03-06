﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;


namespace Maki_Installer.Business
{
    internal partial class PSmanager
    { //Carlos Salgado

        private PS.Chocolatey chocolate = new PS.Chocolatey();
        private PS.Chocolatey.Pin chocopin = new PS.Chocolatey.Pin();
        private PS.OneGet oneget = new PS.OneGet();
        private PS.Installation inst = new PS.Installation();

        // CHOCOLATEY 
        internal Collection<string> install(string package, string version)
        {
            return chocolate.install(package, version);
        } //instala el paquete que se le pase en la versión que se le pida
        internal Collection<string> install(string package)
        {
            return chocolate.install(package);
        } //instala el paquete que se le pase
        internal Collection<string> upgrade(string package)
        {
            return chocolate.upgrade(package);
        } //actualiza el paquete que se le pase
        internal Collection<string> outdated()
        {
            return chocolate.outdated();
        } //Devuelve una lista con todos los paquetes desactualizados
        internal Collection<string> uninstall(string package)
        {
            return chocolate.uninstall(package);
        } //desinstala el paquete que se le pase
        internal Collection<string> listLocal()
        {
            return chocolate.listLocal();
        } //lista de los paquetes instalados
        internal Collection<string> listRemote(string filter = "")
        {
            return chocolate.listAll(filter);
        } //lista de los paquetes en el repositorio de chocolatey (prefiero usar oneget para esto) 
        internal string pinAdd(string package, string version)
        {
            return chocopin.Add(package, version);
        }  //hace que un paquete se quede en la versión que se pida
        internal string pinAdd(string package)
        {
            return chocopin.Add(package);
        } //hace que un paquete se quede en la versión instalada
        internal string pinRemove(string package)
        {
            return chocopin.Remove(package);
        } //quita el bloqueo de actualización
        internal string pinList()
        {
            return chocopin.List();
        } //listea los paquetes que están bloqueados de actualizarse

        //ONEGET
        internal Collection<PSObject> getPackageListRemote()
        {
          return oneget.getPackageListRemote();
        } //return a list of all oneget packages available in REMOTE REPOSITORY and OVERWRITES LOCAL File (161MB so far) 
        internal Collection<PSObject> getPackageListLocal()
        {
            return oneget.getPackageListLocal();
        } //return a list of all oneget packages available LOCALLY STORED

        //INSTALL
        internal bool installChoco()
        {
            if (inst.isChocoInstalled())
                return true;
            else
            {
                inst.setExecutionPolicy();
                inst.installChocolatey();
                if (inst.isChocoInstalled()) { return true; }
                else return false;
            }
        } //Installs chocolatey, return true if its installed, false if installation failed
    }//psmanager
}//namespace

