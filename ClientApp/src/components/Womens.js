import React, { useState, useEffect } from 'react';
import { useNavigate } from "react-router-dom";
import HomeBanner from "./HomeBanner";
import "./../styles/Home.css";
import ShoesCard from "./ShoesCard";
import axios from "axios";


const Women = () => {

    const nav = useNavigate();
    const [shoes, setShoes] = useState([]);

    useEffect(() => {

        const token = localStorage.getItem("token");
        if (!token) {
            nav("/signup");
        } else {
            fetchAllShoes();
        }
    }, []);

    const handleClearLocalStorage = () => {
        localStorage.removeItem("token");
        localStorage.removeItem("userLoggedIn");
    };

    const fetchAllShoes = async () => {
        try {
            const response = await axios.get("/api/shoe/category/W");
            console.log("API Response", response)
            setShoes(response.data);
        } catch (error) {
            console.log("Failed to fetch all shoes", error);
        }
    }
    return (
        <main className="MainContainer">
            <HomeBanner imageUrl="/images/Jordan1Valentines.png" ShoeClass="AIR JORDAN 1" ShoeName="Retro High GG Valenties" />
            <ShoesCard shoes={ shoes } />
        </main>
    )
}

export default Women;
