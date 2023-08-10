import React, { useState, useEffect } from "react";
import "./../styles/Search.css";
import ShoesCard from "./ShoesCard";
import { useNavigate } from "react-router-dom";
import axios from "axios";

const Search = () => {
    const nav = useNavigate();
    const [searchValue, setSearchValue] = useState("");
    const [shoes, setShoes] = useState([]);
    const [isLoading, setIsLoading] = useState(false);
    const [userId, setUserId] = useState(null);

    useEffect(() => {
        const token = localStorage.getItem("token");

        if (!token) {
            nav("/signup")
        } else {
            setUserId(localStorage.getItem("userId"))
        }
    }, []);

    const handleSearch = async () => {
        try {
            setIsLoading(true);
            const response = await axios.get(`/api/shoe/search/${searchValue}`);
            setShoes(response.data);
            setIsLoading(false);
        } catch (error) {
            console.log("Search failed", error);
            setIsLoading(false);
        }
    }

    const handleSearchInputChange = async (e) => {
        setSearchValue(e.target.value);
        handleSearch();
    }

    return (
        <section className="SearchContainer">
            <p className="SearchTitle">LOOK FOR THE SHOE</p>
            <p className="SearchTitle">THAT FITS YOUR</p>
            <p className="SearchTitle">STYLE</p>
            <input className="SearchInput" type="search" placeholder="SEARCH" value={searchValue} onChange={handleSearchInputChange} />
            <ShoesCard shoes={shoes} userId={ userId } />
        </section>
    )
}

export default Search;