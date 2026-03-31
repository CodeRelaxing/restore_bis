import { z } from "zod"
export const loginSchema = z.object({
    email: z.string().email(),
    password: z.string().min(6, {
        message: "password 6 caratteri"
    })
});

export type LoginSchema = z.infer<typeof loginSchema>;