import React, { useEffect } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import Layout from './components/Layout';
import './custom.css';

const App = () => {

    //useEffect(() => {
    //    window.addEventListener("beforeunload", handleClearLocalStorage);

    //    return () => {
    //        window.removeEventListener("beforeunload", handleClearLocalStorage);
    //    };
    //}, []);

    //const handleClearLocalStorage = () => {
    //    localStorage.removeItem("token");
    //    localStorage.removeItem("userLoggedIn");
    //};

    return (
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </Layout>
    );
}

export default App;
