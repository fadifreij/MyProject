import React from 'react';
import { Link, Outlet } from 'react-router-dom';
import { Header } from './header/Header'
import { Footer } from './footer/Footer'
export function Layout(){
    return (
        <>
            <header>
                <Header></Header>
            </header>
            <main>
                <Outlet /> 
            </main>
            <Footer />

           

        </>
    )
}