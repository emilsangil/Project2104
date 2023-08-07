import React, { useState } from "react";
import "./../styles/Search.css";
import ShoesCard from "./ShoesCard";

const Search = () => {
    const [searchValue, setSearchValue] = useState("");
    return (
        <section className="SearchContainer">
            <p className="SearchTitle">LOOK FOR THE SHOE</p>
            <p className="SearchTitle">THAT FITS YOUR</p>
            <p className="SearchTitle">STYLE</p>
            <input className="SearchInput" type="search" placeholder="SEARCH" value={searchValue} onChange={(e) => setSearchValue(e.target.value)} />
            <ShoesCard />
        </section>
    )
}

export default Search;