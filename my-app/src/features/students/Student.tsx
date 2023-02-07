import { Grid } from "@mui/material";
import { IStudent } from "../../models/IStudents";

export function Student({ id, name }: IStudent) {
    return <>
        <Grid item xs={12} sm={2}>
            {id}
        </Grid>
        <Grid item xs={12} sm={10}>
            {name}
        </Grid>
    </>;
}
