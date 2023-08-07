import React from 'react';
import NavMenu from './NavMenu';
import Footer from "./Footer";
import { useLocation } from "react-router-dom";

const Layout = ({children }) => {
    const location = useLocation();

    const hideNav = location.pathname === "/signup" || location.pathname === "/signin";
    return (
        <div>
            {!hideNav && <NavMenu />}
            {children}
            <Footer />
        </div>
    );
}

export default Layout;


