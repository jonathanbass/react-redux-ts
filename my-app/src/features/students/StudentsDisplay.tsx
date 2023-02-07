import { gql, useQuery } from "@apollo/client";
import { Container, Grid } from "@mui/material";
import { IStudents } from "../../models/IStudents";
import { Student } from "./Student";
import './StudentsDisplay.scss';

export function StudentsDisplay() {
    const GetStudentsQuery = gql`
    query {
      students(where: { id: {gt: 100}}) {
        id
        name
      }
    }`;

    const response = useQuery<IStudents>(GetStudentsQuery);
    const students = response.data?.students;

    if (!students) {
        return null;
    }

    return <div className={"students-display"}>
        <Container>
            <strong>Current Students</strong>
            <Grid container marginTop={0} spacing={2} width={"600px"}>
                <Grid item xs={12} sm={2} className={"header"}>
                    Id
                </Grid>
                <Grid item xs={12} sm={10} className={"header"}>
                    Name
                </Grid>
                {students.map(student => (
                    <Student key={student.id} id={student.id} name={student.name} />
                ))}
            </Grid>
        </Container>
    </div>;
}
