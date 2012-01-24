package za.co.mathmuncher.exercise;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;
import za.co.mathmuncher.domain.AnthropodExerciseRequest;
import za.co.mathmuncher.domain.AnthropodExerciseResponse;

@Endpoint
public class ExerciseEndpoint {

    private static final String NAMESPACE_URI = "http://mathmuncher.co.za/ws/schemas/ex";

    @Autowired
    private ExerciseService exerciseService;

    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "anthropodExerciseRequest")
    public @ResponsePayload
    AnthropodExerciseResponse handlAnthropodExerciseRequest(@RequestPayload AnthropodExerciseRequest anthropodExerciseRequest)
        throws Exception {
        return exerciseService.generateAnthropodExercise(anthropodExerciseRequest.getType());
    }

}
