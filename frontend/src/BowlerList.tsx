import { useEffect, useState } from "react";
import {bowl} from "./types/bowl"

function BowlerList() {
    const [bowlers, setBowlers] = useState<bowl[]>([]);
    
    useEffect(() => {
        const fetchData = async () => {
            const response = await fetch("https://localhost:5000/api/BowlingLeague");
            const data = await response.json();
            setBowlers(data);
        };
        fetchData();
    }, []);


    return (
        <>
           <h2>List of Bowlers</h2>
           <div className="table-container">
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Team</th>
                        <th>Address</th>
                        <th>Phone</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        bowlers.map((loop) => (
                            <tr key={loop.bowlerID}>
                                <td>{loop.bowlerFirstName} {loop.bowlerMiddleInit} {loop.bowlerLastName}</td>
                                <td>{loop.teamName}</td>
                                <td>{loop.bowlerAddress} {loop.bowlerCity}, {loop.bowlerState}  {loop.bowlerZip}</td>
                                <td>{loop.bowlerPhoneNumber}</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
           </div>
        </>
    );
}

// bowlerID: number;
// bowlerFirstName: string;
// bowlerMiddleInit: string;
// bowlerLastName: string;
// teamID: number;
// teamName: string;
// bowlerAddress: string;
// bowlerCity: string;
// bowlerState: string;
// bowlerZip: number;
// bowlerPhoneNumber: string;
export default BowlerList;