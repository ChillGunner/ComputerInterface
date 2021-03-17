﻿using ComputerInterface.Interfaces;
using Zenject;

namespace ComputerInterface.RoomBrowser
{
    internal class MainInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<RoomExplorer>().FromNewComponentOnNewGameObject().AsSingle();

            Container.Bind<IComputerModEntry>().To<RoomBrowserEntry>().AsSingle();
        }
    }
}